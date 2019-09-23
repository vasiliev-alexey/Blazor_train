using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaSPA.Server.DataStores;
using PizzaSPA.Shared;

namespace PizzaSPA.Server.Controllers
{
    
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private PizzaPlaceDbContext _db;
        public OrdersController(PizzaPlaceDbContext db)
        {
            _db = db;
        }
        [HttpPost("/orders")]
        public IActionResult CreateOrder([FromBody] Basket basket)
        {
            var customer = basket.Customer;
            var order = new Order()
            {
                PizzaOrders = new List<PizzaOrder>()
            };
            customer.Order = order;
            foreach (var pizzaId in basket.Orders)
            {
                var pizza = _db.Pizzas.Single(p => p.Id == pizzaId);
                order.PizzaOrders.Add(new PizzaOrder
                {
                    Pizza = pizza,
                    Order = order
                });
            }
            order.TotalPrice =
                order.PizzaOrders.Sum(po => po.Pizza.Price);
            _db.Customers.Add(customer);
            _db.SaveChanges();
            return Ok();
        }

    }
}