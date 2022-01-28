using AutoMapper;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.DataContracts.Models;

namespace TmbAnalyst.Services.Manager.Mapping;

public class UserRoleProfile : Profile
{
    public UserRoleProfile()
    {
        CreateMap<UserRole, RoleModel>()
            .IncludeMembers(x=>x.Role);
    }
}