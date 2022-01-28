using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Entities;

public class UserRole : IUnique<int>
{
    public ulong UserId { get; set; }
    public int RoleId { get; set; }
    public Role Role { get; set; }
    public int Id { get; set; }
}