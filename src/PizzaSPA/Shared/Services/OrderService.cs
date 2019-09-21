using System;
using System.Threading.Tasks;
using PizzaSPA.Shared.Interfaces;

namespace PizzaSPA.Shared.Services
{
    public class OrderService : IOrderService
    {
        public Task PlaceOrder(Basket basket)
        {
            Console.WriteLine("Заказ размещен из сервиса");
            return  Task.CompletedTask;

        }
    }
}