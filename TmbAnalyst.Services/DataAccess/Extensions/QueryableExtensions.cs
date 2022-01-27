using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TmbAnalyst.Services.DataAccess.Extensions;

public static class QueryableExtensions
{
    public static async Task<T> SingleOrNotFoundAsync<T>(this IQueryable<T> query)
    {
        try
        {
            return await query.SingleAsync();
        }
        catch (InvalidOperationException ex)
        {
            throw new KeyNotFoundException("The requested resource could not be found.", ex);
        }
    }
}