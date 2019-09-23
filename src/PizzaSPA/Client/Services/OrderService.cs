using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using PizzaSPA.Shared;
using PizzaSPA.Shared.Interfaces;

namespace PizzaSPA.Client.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;

        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task PlaceOrder(Basket basket)
        {
            await _httpClient.PostJsonAsync("/orders", basket);
        }
    }
}