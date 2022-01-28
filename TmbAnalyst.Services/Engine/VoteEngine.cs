using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TmbAnalyst.Services.DataAccess;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.Engine.Contracts;
using TmbAnalyst.Services.Utilities.ThatsMyBis.Models;

namespace TmbAnalyst.Services.Engine;

public class VoteEngine : IVoteEngine
{
    private readonly TmbAnalystDbContext _dbContext;

    public VoteEngine(TmbAnalystDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<VoteItem>> CreateVoteItems()
    {
        var wishlistItems = await _dbContext
            .CharacterItems
            .Where(x => x.Type == TmbDataConstants.ItemType.Wishlist)
            .Where(x => !_dbContext.CharacterItems
                .Any(sub => sub.Type == TmbDataConstants.ItemType.Received &&
                            sub.CharacterId == x.CharacterId &&
                            sub.ItemId == x.ItemId))
            .GroupBy(x => x.ItemId)
            .Where(x => x.Count() > 1)
            .Select(x => new VoteItem
            {
                ItemId = x.Key,
                EligibleCharacters = x.Select(c => new VoteItemCharacter
                {
                    CharacterId = c.CharacterId
                }).ToList()
            })
            .ToListAsync();
        return wishlistItems;
    }
}