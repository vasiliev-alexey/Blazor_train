using System.Threading.Tasks;

namespace PizzaSPA.Shared.Interfaces
{
    public interface IOrderService
    {
        Task PlaceOrder(Basket basket);
    }
}