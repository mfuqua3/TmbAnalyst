using System;
using System.Collections.Generic;
using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Entities;

public class Vote : ICreated, IUnique<int>
{
    public int Id { get; set; }
    public DateTime ActiveUntil { get; set; }
    public DateTime Created { get; set; }
    public List<VoteItem> VoteItems { get; set; }
}