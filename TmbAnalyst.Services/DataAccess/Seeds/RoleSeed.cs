using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.Utilities;

namespace TmbAnalyst.Services.DataAccess.Seeds;

public class RoleSeed : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.SeedFromEnum<Role, Enums.Role>();
    }
}