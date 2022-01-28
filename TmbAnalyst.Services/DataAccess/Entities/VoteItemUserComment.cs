using System;
using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Entities;

public class VoteItemUserComment : IUnique<int>, ITracked
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public int VoteItemUserId { get; set; }
    public VoteItemUser VoteItemUser { get; set; }
}