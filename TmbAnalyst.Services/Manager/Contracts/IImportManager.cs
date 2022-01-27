using System.Threading.Tasks;
using TmbAnalyst.Services.DataContracts.Constants;

namespace TmbAnalyst.Services.Manager.Contracts;

public interface IImportManager
{
    Task ImportWishlistData(string rawImport, ImportFormat format);
    Task ImportItemData(string rawImport, ImportFormat format);
}