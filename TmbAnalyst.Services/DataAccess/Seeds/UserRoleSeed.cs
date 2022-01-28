using System.Collections.Generic;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.Utilities;

namespace TmbAnalyst.Services.DataAccess.Seeds;

public class UserRoleSeed : SeedConfiguration<UserRole>
{
    protected override IEnumerable<UserRole> SeedData => new[]
    {
        new UserRole()
        {
            Id = 1,
            UserId = 188747778535456768,
            RoleId = (int)Enums.Role.Developer
        },
        new UserRole()
        {
            Id = 2,
            UserId = 188747778535456768,
            RoleId = (int)Enums.Role.Admin
        },
        new UserRole()
        {
            Id = 3,
            UserId = 188747778535456768,
            RoleId = (int)Enums.Role.Council
        },
        new UserRole()
        {
            Id = 4,
            UserId = 188747778535456768,
            RoleId = (int)Enums.Role.User
        },
    };
}