using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using TmbAnalyst.Services.Utilities.ThatsMyBis.Models;

namespace TmbAnalyst.Services.Utilities.ThatsMyBis;

public interface ITmbDataParser
{
    List<TmbCsvItem> ParseCsvItemExport(string csvRaw);
    List<TmbCsvGuildItem> ParseCsvGuildDataExport(string csvRaw);
    List<TmbCsvItemNote> ParseCsvGuildItemExport(string csvRaw);
}

public class TmbDataParser : ITmbDataParser
{
    public List<TmbCsvItem> ParseCsvItemExport(string csvRaw)
        => ParseCsvExport<TmbCsvItem>(csvRaw);

    public List<TmbCsvGuildItem> ParseCsvGuildDataExport(string csvRaw)
        => ParseCsvExport<TmbCsvGuildItem>(csvRaw);

    public List<TmbCsvItemNote> ParseCsvGuildItemExport(string csvRaw)
        => ParseCsvExport<TmbCsvItemNote>(csvRaw);

    private List<T> ParseCsvExport<T>(string csvRaw)
    {
        using var reader = new StringReader(csvRaw);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        return csv.GetRecords<T>().ToList();
    }
}