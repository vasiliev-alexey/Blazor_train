using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaSPA.Shared;

namespace PizzaSPA.Server.Controllers
{

    [ApiController]
    public class PizzasController : ControllerBase
    {

        private static List<Pizza> pizzas = new List<Pizza>
        {
            new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy ),
            new Pizza(2, "Margarita", 7.99M, Spiciness.None ),
            new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot )
        };

        [HttpGet("/pizzas")]
        public IQueryable<Pizza> GetPizzas()
        {
            return pizzas.AsQueryable();
        }
    }
}