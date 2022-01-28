using System.Collections.Generic;
using System.Linq;
using TmbAnalyst.Services.DataAccess.Entities;

namespace TmbAnalyst.Services.DataAccess.Seeds;

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