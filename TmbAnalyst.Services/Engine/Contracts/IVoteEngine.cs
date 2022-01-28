using System.Collections.Generic;
using System.Threading.Tasks;
using TmbAnalyst.Services.DataAccess.Entities;

namespace TmbAnalyst.Services.Engine.Contracts;

public interface IVoteEngine
{
    Task<List<VoteItem>> CreateVoteItems();
}