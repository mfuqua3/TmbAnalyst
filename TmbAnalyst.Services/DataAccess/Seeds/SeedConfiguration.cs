using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TmbAnalyst.Services.DataAccess.Entities;

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

public class ItemSourceCategorySeed : SeedConfiguration<ItemSourceCategory>
{
    protected override IEnumerable<ItemSourceCategory> SeedData =>
        ItemSeedUtility.Items
            .GroupBy(x => x.InstanceName)
            .Select((grp, idx) => new ItemSourceCategory
            {
                Id = idx + 1,
                Name = grp.Key
            });
}

public class ItemSourceSeed : SeedConfiguration<ItemSource>
{

    protected override IEnumerable<ItemSource> SeedData =>
        ItemSeedUtility.Items
            .GroupBy(x => x.SourceName)
            .Select((grp, grpIndex) =>
                new ItemSource()
                {
                    ItemSourceCategoryId = ItemSeedUtility.SourceCategoryIdLookup[grp.First().InstanceName],
                    Id = grpIndex + 1,
                    Name = grp.Key
                });
}

public class ItemSeed : SeedConfiguration<Item>
{
    protected override IEnumerable<Item> SeedData =>
        ItemSeedUtility.Items
            .GroupBy(x => x.ItemId)
            .Select(x => x.First())
            .Select(x =>
                new Item
                {
                    ItemSourceId = ItemSeedUtility.SourceIdLookup[x.SourceName],
                    Id = x.ItemId,
                    Name = x.ItemName
                });
}