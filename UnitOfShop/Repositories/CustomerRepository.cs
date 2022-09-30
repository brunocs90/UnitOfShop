using UnitOfShop.Data;
using UnitOfShop.Models;
using UnitOfShop.Repositories.Interface;

namespace UnitOfShop.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }
        public void Save(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }
    }
}
