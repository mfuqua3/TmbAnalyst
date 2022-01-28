using AutoMapper;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.DataContracts.Models;
using TmbAnalyst.Services.DataContracts.Requests;

namespace TmbAnalyst.Services.Manager.Mapping;

public class VoteProfile : Profile
{
    public VoteProfile()
    {
        CreateMap<Vote, VoteModel>();
        CreateMap<CreateVoteRequest, Vote>();
    }
}