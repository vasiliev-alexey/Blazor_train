namespace PizzaSPA.Shared
{
    public class Pizza
    {
        public Pizza()
        {
        }

        public Pizza(int id, string name,
            decimal price, Spiciness spicyness)
        {
            Id = id;
            Name = name;
            Price = price;
            Spicyness = spicyness;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Spiciness Spicyness { get; set; }
    }
}