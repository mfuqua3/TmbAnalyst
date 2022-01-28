using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace TmbAnalyst.ClientApp.Razor.DependencyInjection;

public static class RazorClientAppRegistrar
{
    public static void AddRazorClientApp(this IServiceCollection services, IWebHostEnvironment environment)
    {
        services
            .AddRazorPages()
            .AddApplicationPart(Assembly.GetExecutingAssembly())
            .AddRazorRuntimeCompilation(opt =>
            {
                var assembly = Assembly.GetExecutingAssembly();
                opt.FileProviders.Add(new PhysicalFileProvider(Path.Combine(environment.ContentRootPath,
                    "../TmbAnalyst.ClientApp.Razor")));
                opt.AdditionalReferencePaths.Add(assembly.Location);
            });
        services.AddControllers()
            .AddApplicationPart(Assembly.GetExecutingAssembly())
            .AddControllersAsServices();
    }

    public static void UseClientAppStaticFiles(this IApplicationBuilder app)
    {
        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new ManifestEmbeddedFileProvider(Assembly.GetExecutingAssembly(), "wwwroot")
        });
    }
}