using System.Collections.Generic;

namespace PizzaSPA.Shared
{
    public class Basket
    {
        private Customer Customer { get; set; } = new Customer();

        public List<int> Orders { get; set; } = new List<int>();

        public bool HasPaid { get; set; } = false;
    }
}