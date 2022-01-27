using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TmbAnalyst.Services.DataAccess.Entities;

namespace TmbAnalyst.Services.DataAccess.EntityConfigurations;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.Property(x => x.Id)
            .ValueGeneratedNever();
    }
}