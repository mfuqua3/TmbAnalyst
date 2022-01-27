using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Extensions;

public static class PagingQueries
{
    public static IOrderedQueryable<T> ApplySorts<T>(this IQueryable<T> query, IList<string> sorts)
    {
        sorts ??= new List<string>();

        var first = true;
        foreach (var sort in sorts)
        {
            var isDescending = sort.Trim().StartsWith('-');
            var fieldName = sort.Replace("-", string.Empty).Trim();

            if (first)
            {
                query = query.OrderByFieldName(fieldName, !isDescending);
                first = false;
            }
            else
            {
                query = query.ThenByFieldName(fieldName, !isDescending);
            }
        }

        return query as IOrderedQueryable<T>;
    }

    public static IOrderedQueryable<T> OrderByFieldName<T>(this IQueryable<T> query, string fieldName, bool isAscending)
    {
        var parameter = Expression.Parameter(typeof(T), "p");
        string command = isAscending
            ? "OrderBy"
            : "OrderByDescending";

        var property = typeof(T).GetProperty(fieldName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
        if (property == null)
        {
            throw new ArgumentException($"Property {property} does not exist on type.");
        }

        var propertyAccess = Expression.MakeMemberAccess(parameter, property);
        var orderByExpression = Expression.Lambda(propertyAccess, parameter);

        Expression expression = Expression.Call(typeof(Queryable), command, new Type[] { typeof(T), property.PropertyType }, query.Expression, Expression.Quote(orderByExpression));

        return query.Provider.CreateQuery<T>(expression) as IOrderedQueryable<T>;
    }

    public static IOrderedQueryable<T> ThenByFieldName<T>(this IQueryable<T> query, string fieldName, bool isAscending)
    {
        var parameter = Expression.Parameter(typeof(T), "p");
        string command = isAscending
            ? "ThenBy"
            : "ThenByDescending";

        var property = typeof(T).GetProperty(fieldName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
        if (property == null)
        {
            throw new ArgumentException($"Property {property} does not exist on type.");
        }

        var propertyAccess = Expression.MakeMemberAccess(parameter, property);
        var orderByExpression = Expression.Lambda(propertyAccess, parameter);

        Expression expression = Expression.Call(typeof(Queryable), command, new Type[] { typeof(T), property.PropertyType }, query.Expression, Expression.Quote(orderByExpression));

        return query.Provider.CreateQuery<T>(expression) as IOrderedQueryable<T>;
    }

    public static IQueryable<T> Page<T>(this IOrderedEnumerable<T> query, IPaginated parameters, out int count)
    {
        return query.AsQueryable().Page(parameters, out count);
    }

    public static IEnumerable<T> Page<T>(this IEnumerable<T> query, IPaginated parameters, out int count)
        => query.AsQueryable().Page(parameters, out count);
    public static IQueryable<T> Page<T>(this IQueryable<T> query, IPaginated parameters, out int count)
    {
        if (parameters.Page < 0)
        {
            throw new ArgumentException("Invalid page. Please specify a page greater than or equal to zero.");
        }

        if (parameters.PageSize < 0)
        {
            throw new ArgumentException("Invalid page size. Please specify a page size greater than or equal to zero.");
        }
        count = query.Count();
        if (parameters.PageSize == 0)
        {
            return query.Where(x => false);
        }

        var size = Math.Min(parameters.PageSize, int.MaxValue);
        return query
            .Skip(Math.Max(parameters.Page, 0) * size)
            .Take(size);
    }
}