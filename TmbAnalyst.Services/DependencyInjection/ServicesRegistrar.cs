using Microsoft.Extensions.DependencyInjection;
using TmbAnalyst.Services.Utilities.ThatsMyBis;

namespace TmbAnalyst.Services.DependencyInjection;

public static class ServicesRegistrar
{
    public static void AddTmbAnalystCore(this IServiceCollection services)
    {
        services.AddThatsMyBisUtilities();
    }
}