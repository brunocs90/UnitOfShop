using UnitOfShop.Models;

namespace UnitOfShop.Repositories.Interface
{
    public interface IOrderRepository
    {
        void Save(Order order);
        IEnumerable<Order> GetAll();        
    }
}
