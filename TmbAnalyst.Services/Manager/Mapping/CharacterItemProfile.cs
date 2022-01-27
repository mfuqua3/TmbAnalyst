using System;
using System.Linq;
using AutoMapper;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.DataContracts.Models;
using TmbAnalyst.Services.Utilities.ThatsMyBis.Models;

namespace TmbAnalyst.Services.Manager.Mapping;

public class CharacterItemProfile : Profile
{
    public CharacterItemProfile()
    {
        CreateMap<TmbCsvGuildItem, CharacterItem>()
            .ForMember(x => x.Type, o => o.MapFrom(x => x.Type))
            .ForMember(x => x.Date, o => o.MapFrom(x=>x.CreatedAt.GetValueOrDefault()))
            .ForMember(x => x.OrderNumber, o => o.MapFrom(x => x.SortOrder.GetValueOrDefault()))
            .ForMember(x => x.ItemId, o => o.MapFrom(x => x.ItemId))
            .ForMember(x => x.CharacterName, o => o.MapFrom(x => x.CharacterName));
    }
}