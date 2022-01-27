using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TmbAnalyst.Services.DataAccess.Entities;

namespace TmbAnalyst.Services.DataAccess.EntityConfigurations;

public class CharacterItemConfiguration : IEntityTypeConfiguration<CharacterItem>
{
    public void Configure(EntityTypeBuilder<CharacterItem> builder)
    {
        builder.HasIndex(x => new { x.CharacterId, x.ItemId, x.Type, x.Date })
            .IsUnique();
    }
}