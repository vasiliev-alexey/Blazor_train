using System.Collections.Generic;
using System.Linq;

namespace PizzaSPA.Shared
{
    public class Menu
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public Pizza GetPizza(int id)
        {
            return Pizzas.FirstOrDefault(_ => _.Id == id);
        }
    }
}