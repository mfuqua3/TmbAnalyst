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
        ItemSeedUtility.Items.GroupBy(x => x.InstanceName)
            .Select((grp, idx) => new ItemSourceCategory
            {
                Id = idx + 1,
                Name = grp.Key
            });
}

public class ItemSourceSeed : SeedConfiguration<ItemSource>
{
    private int _idCounter = 1;

    protected override IEnumerable<ItemSource> SeedData =>
        ItemSeedUtility.Items
            .GroupBy(x => x.InstanceName)
            .SelectMany((group, groupIdx) => group
                .GroupBy(x => x.SourceName)
                .Select((grp, idx) => new ItemSource
                {
                    Id = _idCounter++,
                    OrderNumber = idx,
                    ItemSourceCategoryId = groupIdx + 1,
                    Name = grp.Key
                }));
}

public class ItemSeed : SeedConfiguration<Item>
{
    protected override IEnumerable<Item> SeedData =>
        ItemSeedUtility.Items
            .GroupBy(x => x.SourceName)
            .SelectMany((sourceGroup, sourceGroupIdx) =>
                sourceGroup.Select(x => new Item
                {
                    Id = x.ItemId,
                    ItemSourceId = sourceGroupIdx + 1,
                    Name = x.ItemName
                }))
            .GroupBy(x => x.Id)
            .Select(x => x.First());
}