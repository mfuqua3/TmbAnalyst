using System.Threading.Tasks;
using TmbAnalyst.Services.DataContracts.Constants;
using TmbAnalyst.Services.Manager.Contracts;
using TmbAnalyst.Services.Utilities.ThatsMyBis;

namespace TmbAnalyst.Services.Manager;

public class ImportManager : IImportManager
{
    private readonly ITmbDataParser _tmbDataParser;

    public ImportManager(ITmbDataParser tmbDataParser)
    {
        _tmbDataParser = tmbDataParser;
    }
    public async Task ImportWishlistData(string rawImport, ImportFormat format)
    {
        throw new System.NotImplementedException();
    }

    public async Task ImportItemData(string rawImport, ImportFormat format)
    {
        throw new System.NotImplementedException();
    }
}