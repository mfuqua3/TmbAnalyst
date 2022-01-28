using System;
using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Entities;

public class VoteItemUserCharacter : IUnique<int>, ITracked, IOrdered
{
    public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public int OrderNumber { get; set; }
    public int VoteItemUserId { get; set; }
    public VoteItemUser VoteItemUser { get; set; }
    public int CharacterId { get; set; }
    public Character Character { get; set; }
}