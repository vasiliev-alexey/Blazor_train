namespace PizzaSPA.Shared
{
    public class State
    {
        public Menu Menu { get; set; } = new Menu();
        public Basket Basket { get; set; } = new Basket();

        public Ui Ui { get; set; } = new Ui();


    }
}