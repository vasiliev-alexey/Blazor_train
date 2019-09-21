using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using PizzaSPA.Shared.Interfaces;
using PizzaSPA.Shared.Services;

namespace PizzaSPA.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IOrderService, OrderService>();
            services.AddSingleton<IMenuService, FixedMenuService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
