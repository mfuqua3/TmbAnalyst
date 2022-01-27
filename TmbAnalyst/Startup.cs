using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TmbAnalyst.ClientApp.Razor.DependencyInjection;
using TmbAnalyst.Middleware;
using TmbAnalyst.Services.DataAccess;
using TmbAnalyst.Services.DependencyInjection;
using TmbAnalyst.Services.Utilities.Configuration;
using TmbAnalyst.Services.Utilities.Exceptions;

namespace TmbAnalyst
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            _configuration = configuration;
            _webHostEnvironment = webHostEnvironment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TmbAnalystDbContext>(opt =>
            {
                opt.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddRazorClientApp(_webHostEnvironment);
            services.AddOptions();
            services.AddHealthChecks();
            services.AddCors();
            services.Configure<DevelopmentOptions>(_configuration.GetSection("Development"));
            services.AddApplicationMiddleware();
            services.AddTmbAnalystCore();
            services.AddAutoMapper(typeof(ServicesRegistrar).Assembly);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, TmbAnalystDbContext dbContext)
        {
            dbContext.Database.Migrate();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseExceptionHandling();
            app.UseHttpsRedirection();
            app.UseCors(opt =>
                opt
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .SetIsOriginAllowed(_ => true));
            app.UseClientAppStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/coffee", _ => throw new ServerIsTeapotException());
                endpoints.MapHealthChecks("/health");
                endpoints.MapRazorPages();
            });
        }
    }
}