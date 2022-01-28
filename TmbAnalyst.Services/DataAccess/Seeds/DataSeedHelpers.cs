using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TmbAnalyst.Services.DataContracts.Interfaces;
using TmbAnalyst.Services.Utilities.Extensions;

namespace TmbAnalyst.Services.DataAccess.Seeds;

public static class DataSeedHelpers
{
    public static void SeedFromEnum<TEntity, TEnum>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : class, IEnumTable, new()
        where TEnum : struct, Enum, IComparable, IFormattable, IConvertible
    {
        var enumValues = Enum.GetValues<TEnum>();
        var dataSeed = enumValues.CreateFromEnum<TEntity, TEnum>();
        builder.HasData(dataSeed);
    }

    public static IEnumerable<TEntity> CreateFromEnum<TEntity, TEnum>(this TEnum[] enumValues)
        where TEntity : class, IEnumTable, new()
        where TEnum : struct, Enum, IComparable, IFormattable, IConvertible
    {
        foreach (var enumValue in enumValues)
        {
            var newEntity = Activator.CreateInstance<TEntity>();
            newEntity.Id = enumValue.ToInt32(null);
            newEntity.Name = enumValue.ToString();
            newEntity.Description = enumValue.GetEnumDescription() ?? enumValue.ToString();
            yield return newEntity;
        }
    }

}