using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TmbAnalyst.Services.DataAccess;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.Engine.Contracts;

namespace TmbAnalyst.Services.Engine;

public class CharacterEngine : ICharacterEngine
{
    private readonly TmbAnalystDbContext _dbContext;

    public CharacterEngine(TmbAnalystDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task EnsureCreated(IEnumerable<string> characterNames)
    {
        await _dbContext.Characters.BulkMergeAsync(
            characterNames.Select(x => new Character { Name = x }),
            opt => opt.ColumnPrimaryKeyExpression = x => x.Name);
    }
}