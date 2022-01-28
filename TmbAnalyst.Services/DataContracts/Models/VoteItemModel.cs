using System.Collections.Generic;

namespace TmbAnalyst.Services.DataContracts.Models;

public class VoteItemModel
{
    public int ItemId { get; set; }
    public string ItemName { get; set; }
    public List<string> EligibleCharacters { get; set; }
}