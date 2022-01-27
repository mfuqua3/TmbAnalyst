using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.Utilities.Extensions;
using TmbAnalyst.Services.Utilities.ThatsMyBis;
using TmbAnalyst.Services.Utilities.ThatsMyBis.Models;

namespace TmbAnalyst.Services.DataAccess.Seeds;

public static class ItemSeedUtility
{
    private const string LootTableFile = "burning-crusade-loot-table.csv";
    private static List<TmbCsvItem> _Items;

    public static List<TmbCsvItem> Items
    {
        get
        {
            if (_Items == null)
                GetItemsFromFile();
            return _Items;
        }
    }

    public static Dictionary<string, int> SourceCategoryIdLookup =>
        Items.GroupBy(x => x.InstanceName)
            .Select((grp, idx) => new ItemSourceCategory
            {
                Id = idx + 1,
                Name = grp.Key
            }).ToDictionary(x => x.Name, x => x.Id);

    public static Dictionary<string, int> SourceIdLookup =>
        Items
            .GroupBy(x => x.SourceName)
            .Select((grp, grpIndex) =>
                new ItemSource
                {
                    Id = grpIndex + 1,
                    Name = grp.Key
                }).ToDictionary(x => x.Name, x => x.Id);

    private static void GetItemsFromFile()
    {
        var csvResource = Assembly.GetExecutingAssembly().ReadResource(LootTableFile);
        _Items = new TmbDataParser().ParseCsvItemExport(csvResource);
    }
}