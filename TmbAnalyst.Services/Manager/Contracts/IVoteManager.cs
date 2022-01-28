using System.Collections.Generic;
using System.Threading.Tasks;
using TmbAnalyst.Services.DataContracts.Models;
using TmbAnalyst.Services.DataContracts.Requests;

namespace TmbAnalyst.Services.Manager.Contracts;

public interface IVoteManager
{
    Task<VoteModel> CreateVote(CreateVoteRequest createVoteRequest);
    Task<VoteModel> GetCurrentVote();
    Task<List<VoteItemModel>> GetVoteItems(int voteId);
}