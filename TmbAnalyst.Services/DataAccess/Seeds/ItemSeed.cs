using System.Collections.Generic;
using System.Linq;
using TmbAnalyst.Services.DataAccess.Entities;

namespace TmbAnalyst.Services.DataAccess.Seeds;

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