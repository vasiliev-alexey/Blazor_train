using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using PizzaSPA.Client.Services;
using PizzaSPA.Shared;
using PizzaSPA.Shared.Interfaces;
 

namespace PizzaSPA.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddSingleton<State>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
