using System.Threading.Tasks;
using TmbAnalyst.Services.DataContracts.Models;

namespace TmbAnalyst.Services.Manager.Contracts;

public interface IImportManager
{
    Task<WishlistImportResultSummary> ImportWishlistData(string rawImport);
}