namespace PizzaSPA.Shared
{
    using System.Collections.Generic;
    /// <summary>
    /// Корзина
    /// </summary>
    public class Basket
    
    {
        /// <summary>
        /// Заказчик
        /// </summary>
        public Customer Customer { get; set; } = new Customer();

        /// <summary>
        /// Заказы
        /// </summary>
        public List<int> Orders { get; set; } = new List<int>();

        /// <summary>
        /// Заказ оплачен
        /// </summary>
        public bool HasPaid { get; set; } = false;

        /// <summary>
        /// Добавить пиццу
        /// </summary>
        /// <param name="pizzaId">Иднетификтор пиццы</param>
        public void Add(int pizzaId)
        {
            Orders.Add(pizzaId);
        }
        /// <summary>
        /// Удалить пиццу из корзины
        /// </summary>
        /// <param name="pos">Иднетификтор пиццы</param>
        public void Remove(int pos)
        {
            Orders.RemoveAt(pos);
        }
    }
}