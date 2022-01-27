using Microsoft.Extensions.DependencyInjection;
using TmbAnalyst.Services.Manager.Contracts;

namespace TmbAnalyst.Services.Manager;

public static class ManagerRegistrar
{
    public static void AddManagers(this IServiceCollection services)
    {
        services.AddScoped<IImportManager, ImportManager>()
            .AddScoped<IPreVoteManager, PreVoteManager>();
    }
}