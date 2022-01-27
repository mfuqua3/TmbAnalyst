using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using TmbAnalyst.Services.DataAccess;
using TmbAnalyst.Services.DataContracts.Models;
using TmbAnalyst.Services.Manager.Contracts;
using TmbAnalyst.Services.Utilities.ThatsMyBis.Models;

namespace TmbAnalyst.Services.Manager;

public class PreVoteManager : IPreVoteManager
{
    private readonly TmbAnalystDbContext _dbContext;

    public PreVoteManager(TmbAnalystDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<byte[]> GetPreVoteCsv()
    {
        // var receivedItems = await _dbContext
        //     .CharacterItems
        //     .Where(y => y.Type == TmbDataConstants.ItemType.Received)
        //     .Select(x => new { x.CharacterId, x.ItemId })
        //     .ToListAsync();
        var items = await _dbContext
            .CharacterItems
            .Where(x => x.Type == TmbDataConstants.ItemType.Wishlist)
            .OrderByDescending(x=>x.Item.ItemSource.ItemSourceCategoryId)
            .ThenBy(x=>x.Item.ItemSourceId)
            .GroupBy(x => new
            {
                Raid = x.Item.ItemSource.ItemSourceCategory.Name,
                Boss = x.Item.ItemSource.Name,
                Item = x.Item.Name
            })
            .Where(x => x.Count() > 1)
            .Select(grp => new PreVoteCsvModel
            {
                Raid = grp.Key.Raid,
                Boss = grp.Key.Boss,
                Item = grp.Key.Item,
                Users = grp.Select(x => x.Character.Name).ToList()
            })
            .ToListAsync();
        await using var outputStream = new MemoryStream();
        await using var writer = new StreamWriter(outputStream);
        await using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        await csv.WriteRecordsAsync(items);
        return outputStream.ToArray();
    }
}