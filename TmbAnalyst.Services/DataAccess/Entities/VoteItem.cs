using System.Collections.Generic;
using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Entities;

public class VoteItem : IUnique<int>
{
    public int VoteId { get; set; }
    public int Id { get; set; }
    public int ItemId { get; set; }
    public Item Item { get; set; }
    public List<VoteItemCharacter> EligibleCharacters { get; set; }
    public List<VoteItemUser> VoteItemUsers { get; set; }
}