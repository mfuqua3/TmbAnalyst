using System.Collections.Generic;
using System.Reflection;
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

    private static void GetItemsFromFile()
    {
        var csvResource = Assembly.GetExecutingAssembly().ReadResource(LootTableFile);
        _Items = new TmbDataParser().ParseCsvItemExport(csvResource);
    }
}