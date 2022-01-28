using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TmbAnalyst.Services.DataAccess.Seeds;

public abstract class SeedConfiguration<T> : IEntityTypeConfiguration<T>
    where T : class
{
    protected abstract IEnumerable<T> SeedData { get; }

    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasData(SeedData);
    }
}