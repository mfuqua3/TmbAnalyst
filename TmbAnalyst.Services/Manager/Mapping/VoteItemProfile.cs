using System.Linq;
using AutoMapper;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.DataContracts.Models;

namespace TmbAnalyst.Services.Manager.Mapping;

public class VoteItemProfile : Profile
{
    public VoteItemProfile()
    {
        CreateMap<VoteItem, VoteItemModel>()
            .ForMember(x => x.ItemId, o => o.MapFrom(x => x.ItemId))
            .ForMember(x => x.ItemName, o => o.MapFrom(x => x.Item.Name))
            .ForMember(x => x.EligibleCharacters, o => o.MapFrom(x => x.EligibleCharacters.Select(c=>c.Character.Name)));
    }
}