using CsvHelper.Configuration.Attributes;

namespace TmbAnalyst.Services.Utilities.ThatsMyBis.Models;

public class TmbCsvItem
{
    [Name("instance_name")]
    public string InstanceName { get; set; }
    [Name("source_name")]
    public string SourceName { get; set; }
    [Name("item_name")]
    public string ItemName { get; set; }
    [Name("item_quality")]
    public string ItemQuality { get; set; }
    [Name("item_id")]
    public int ItemId { get; set; }
    [Name("url")]
    public string Url { get; set; }
}