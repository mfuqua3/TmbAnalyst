using System.Collections.Generic;
using System.Threading.Tasks;
using TmbAnalyst.Services.DataContracts.Models;

namespace TmbAnalyst.Services.Manager.Contracts;

public interface IUserManager
{
    Task<bool> IsInRole(ulong userId, string role);
    Task AddToRole(ulong userId, string role);
    Task RemoveFromRole(ulong userId, string role);
    Task<List<RoleModel>> GetUserRoles(ulong userId);
}