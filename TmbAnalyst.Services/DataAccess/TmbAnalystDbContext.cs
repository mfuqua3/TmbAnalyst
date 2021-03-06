using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.DataAccess.Extensions;

namespace TmbAnalyst.Services.DataAccess;

public class TmbAnalystDbContext : DbContext
{
    public TmbAnalystDbContext(DbContextOptions<TmbAnalystDbContext> options):base(options)
    {}
    
    public DbSet<Item> Items { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<CharacterItem> CharacterItems { get; set; }
    public DbSet<ItemSource> ItemSources { get; set; }
    public DbSet<ItemSourceCategory> ItemSourceCategories { get; set; }
    
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<Role> Roles { get; set; }
    
    public DbSet<Vote> Votes { get; set; }
    public DbSet<VoteItem> VoteItems { get; set; }
    public DbSet<VoteItemCharacter> VoteItemCharacters { get; set; }
    public DbSet<VoteItemUser> VoteItemUsers { get; set; }
    public DbSet<VoteItemUserCharacter> VoteItemUserCharacters { get; set; }
    public DbSet<VoteItemUserComment> VoteItemUserComments { get; set; }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        this.ProcessCustomInterfaces();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = new())
    {
        this.ProcessCustomInterfaces();
        return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(TmbAnalystDbContext).Assembly);
        builder.RestrictForeignKeyDelete();
        builder.ApplySoftDeleteQueryFilters();
        base.OnModelCreating(builder);
    }
}