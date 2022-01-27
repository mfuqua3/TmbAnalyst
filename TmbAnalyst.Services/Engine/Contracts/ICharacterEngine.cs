using System.Collections.Generic;
using System.Threading.Tasks;

namespace TmbAnalyst.Services.Engine.Contracts;

public interface ICharacterEngine
{
    Task EnsureCreated(IEnumerable<string> characterNames);
}