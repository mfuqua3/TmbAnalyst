using Microsoft.Extensions.DependencyInjection;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.Manager.Contracts;

namespace TmbAnalyst.Services.Manager;

public static class ManagerRegistrar
{
    public static void AddManagers(this IServiceCollection services)
    {
        services.AddScoped<IImportManager, ImportManager>()
            .AddScoped<IPreVoteManager, PreVoteManager>()
            .AddScoped<IUserManager, UserManager>()
            .AddScoped<IVoteManager, VoteManager>();
    }
}