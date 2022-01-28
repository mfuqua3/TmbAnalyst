using System.Collections.Generic;
using TmbAnalyst.Services.DataContracts.Interfaces;

namespace TmbAnalyst.Services.DataAccess.Entities;

public class Role : IEnumTable
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Description { get; set; }
    public List<UserRole> UserRoles { get; set; }
}