using System;
using System.Collections.Generic;
using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Entities;

public class VoteItemUser : IUnique<int>, ITracked
{
    public int Id { get; set; }
    public ulong UserId { get; set; }
    public int VoteItemId { get; set; }
    public VoteItem VoteItem { get; set; }
    public List<VoteItemUserCharacter> VoteItemUserCharacters { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
}