using Microsoft.Extensions.DependencyInjection;
using TmbAnalyst.Services.Engine.Contracts;

namespace TmbAnalyst.Services.Engine;

public static class EngineRegistrar
{
    public static void AddEngines(this IServiceCollection services)
    {
        services.AddScoped<ICharacterEngine, CharacterEngine>();
    }
}