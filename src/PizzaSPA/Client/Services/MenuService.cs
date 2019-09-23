using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using PizzaSPA.Shared;
using PizzaSPA.Shared.Interfaces;
using PizzaSPA.Shared.Services;

namespace PizzaSPA.Client.Services
{
    public class MenuService : IMenuService
    {
        private HttpClient _httpClient;

        public MenuService(HttpClient client)
        {
            this._httpClient = client;
        }

        public async Task<Menu> GetMenu()
        {
            var pizzas =
                await _httpClient.GetJsonAsync<Pizza[]>("/pizzas");

            return new Menu { Pizzas = pizzas.ToList() };
        }
    }
}
