using AutoMapper;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.DataContracts.Models;

namespace TmbAnalyst.Services.Manager.Mapping;

public class RoleProfile : Profile
{
    public RoleProfile()
    {
        CreateMap<Role, RoleModel>();
    }
}