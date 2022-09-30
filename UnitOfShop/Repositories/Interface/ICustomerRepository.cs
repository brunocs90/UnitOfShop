using UnitOfShop.Models;

namespace UnitOfShop.Repositories.Interface
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);

        IEnumerable<Customer> GetAll();
    }
}
