using System;
using CsvHelper.Configuration.Attributes;

namespace TmbAnalyst.Services.Utilities.ThatsMyBis.Models;

public class TmbCsvGuildItem
{
    [Name("type")]
    public string Type { get; set; }
    [Name("raid_group_name")]
    public string RaidGroup { get; set; }
    [Name("member_name")]
    public string MemberName { get; set; }
    [Name("character_name")]
    public string CharacterName { get; set; }
    [Name("character_class")]
    public string CharacterClass { get; set; }
    [Name("character_is_alt")]
    public string CharacterIsAlt { get; set; }
    [Name("character_inactive_at")]
    public DateTime? CharacterInactiveAt { get; set; }
    [Name("character_note")]
    public string CharacterNote { get; set; }
    [Name("sort_order")]
    public int? SortOrder { get; set; }
    [Name("item_name")]
    public string ItemName { get; set; }
    [Name("item_id")]
    public int ItemId { get; set; }
    [Name("is_offspec")]
    public string IsOffspec { get; set; }
    [Name("note")]
    public string Note { get; set; }
    [Name("received_at")]
    public DateTime? ReceivedAt { get; set; }
    [Name("import_id")]
    public string ImportId { get; set; }
    [Name("item_note")]
    public string ItemNote { get; set; }
    [Name("item_prio_note")]
    public string ItemPriorityNote { get; set; }
    [Name("item_tier")]
    public string ItemTier { get; set; }
    [Name("item_tier_label")]
    public string ItemTierLabel { get; set; }
    [Name("created_at")]
    public DateTime? CreatedAt { get; set; }
    [Name("updated_at")]
    public DateTime? UpdatedAt { get; set; }
}