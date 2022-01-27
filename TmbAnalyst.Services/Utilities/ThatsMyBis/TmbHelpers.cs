using Microsoft.Extensions.DependencyInjection;

namespace TmbAnalyst.Services.Utilities.ThatsMyBis;

public static class TmbHelpers
{
    public static void AddThatsMyBisUtilities(this IServiceCollection services)
    {
        services.AddTransient<ITmbDataParser, TmbDataParser>();
    }
}