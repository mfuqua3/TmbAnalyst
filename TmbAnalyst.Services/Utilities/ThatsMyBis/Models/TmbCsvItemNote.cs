using System;
using CsvHelper.Configuration.Attributes;

namespace TmbAnalyst.Services.Utilities.ThatsMyBis.Models;

public class TmbCsvItemNote
{
    [Name("name")]
    public string Name { get; set; }
    [Name("id")]
    public int Id { get; set; }
    [Name("source_name")]
    public string SourceName { get; set; }
    [Name("guild_note")]
    public string GuildNote { get; set; }
    [Name("priority_note")]
    public string PriorityNote { get; set; }
    [Name("tier")]
    public string Tier { get; set; }
    [Name("tier_label")]
    public string TierLabel { get; set; }
    [Name("created_at")]
    public DateTime? CreatedAt { get; set; }
    [Name("name")]
    public DateTime? UpdatedAt { get; set; }
}