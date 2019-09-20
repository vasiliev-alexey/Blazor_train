using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaSPA.Shared.Interfaces
{
    public interface IMenuService
    {
        Task<Menu> GetMenu();
    }
}