using System.Collections.Generic;
using System.Linq;
using TmbAnalyst.Services.DataAccess.Entities;

namespace TmbAnalyst.Services.DataAccess.Seeds;

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