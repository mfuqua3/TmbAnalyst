using System.Threading.Tasks;

namespace TmbAnalyst.Services.Manager.Contracts;

public interface IPreVoteManager
{
    Task<byte[]> GetPreVoteCsv();
}