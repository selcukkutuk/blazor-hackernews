using BlazorHackerNews.Services;
using BlazorHackerNews.Shared;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorHackerNews
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<AppMetaState>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<AppMeta>("head");
            app.AddComponent<App>("app");
        }
    }
}
