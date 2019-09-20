using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaSPA.Shared.Interfaces;

namespace PizzaSPA.Shared.Services
{
    public class FixedMenuService :IMenuService
    {
        public Task<Menu> GetMenu()
        {
            var menu = new Menu
            {
                Pizzas = new List<Pizza>
                {
                    new Pizza(1, @"Пипперони", 500, Spiciness.Spicy),
                    new Pizza(2, "Маргарита", 600, Spiciness.Hot),
                    new Pizza(3, "Диабло", 700, Spiciness.Hot)
                }
            };
            return Task.FromResult<Menu>(menu);
        }
    }
}