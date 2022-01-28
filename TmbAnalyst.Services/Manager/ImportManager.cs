using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TmbAnalyst.Services.DataAccess;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.DataContracts.Models;
using TmbAnalyst.Services.Engine.Contracts;
using TmbAnalyst.Services.Manager.Contracts;
using TmbAnalyst.Services.Utilities.ThatsMyBis;
using TmbAnalyst.Services.Utilities.ThatsMyBis.Models;

namespace TmbAnalyst.Services.Manager;

public class ImportManager : IImportManager
{
    private readonly IMapper _mapper;
    private readonly ITmbDataParser _tmbDataParser;
    private readonly ICharacterEngine _characterEngine;
    private readonly TmbAnalystDbContext _dbContext;

    public ImportManager(
        IMapper mapper,
        ITmbDataParser tmbDataParser,
        ICharacterEngine characterEngine,
        TmbAnalystDbContext dbContext)
    {
        _mapper = mapper;
        _tmbDataParser = tmbDataParser;
        _characterEngine = characterEngine;
        _dbContext = dbContext;
    }

    public async Task<WishlistImportResultSummary> ImportWishlistData(string rawImport)
    {
        var import = _tmbDataParser.ParseCsvGuildDataExport(rawImport);
        await _characterEngine.EnsureCreated(
            import
                .Select(x => x.CharacterName)
                .Distinct()
                .Where(x => !string.IsNullOrEmpty(x)));
        var characterItems = _mapper.Map<List<TmbCsvGuildItem>, List<CharacterItem>>(import);
        var characterIdLookup = await _dbContext
            .Characters
            .WhereBulkContains(import.Select(x => x.CharacterName).Distinct(), character => character.Name)
            .ToDictionaryAsync(x => x.Name, x => x.Id);
        var knownItemIds = _dbContext.Items.Select(x => x.Id).ToHashSet();
        characterItems = characterItems
            .Where(x => characterIdLookup.ContainsKey(x.CharacterName))
            .Select(x =>
            {
                x.CharacterId = characterIdLookup[x.CharacterName];
                if (x.Date == default)
                {
                    x.Date = DateTime.UtcNow;
                }

                return x;
            })
            .Where(x => x.CharacterId != default)
            .Where(x => knownItemIds.Contains(x.ItemId))
            .GroupBy(x => new { x.CharacterId, x.ItemId, x.Type, x.Date })
            .Select(x => x.First())
            .ToList();
        await _dbContext.CharacterItems.BulkSynchronizeAsync(characterItems,
            opt => opt.ColumnPrimaryKeyExpression = x => new { x.CharacterId, x.ItemId, x.Type, x.Date });
        return new WishlistImportResultSummary
        {
            CharacterCount = characterItems.GroupBy(x=>x.CharacterId).Count(),
            ReceivedItemCount = characterItems.Count(x => x.Type==TmbDataConstants.ItemType.Received),
            WishlistItemCount = characterItems.Count(x => x.Type==TmbDataConstants.ItemType.Wishlist),
        };
    }
}