using Microsoft.AspNetCore.Mvc;
using UnitOfShop.Data;
using UnitOfShop.Models;
using UnitOfShop.Repositories.Interface;

namespace UnitOfShop.Controllers
{
    [ApiController]
    [Route("v1/orders")]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Order Post([FromServices]ICustomerRepository customerRepository, 
                          [FromServices]IOrderRepository orderRepository,
                          [FromServices]IUnitOfWork unitOfWork)
        {
            try
            {
                var customer = new Customer { Name = "Cliente " + Guid.NewGuid() };
                var order = new Order { Number = Guid.NewGuid().ToString(), Customer = customer };

                customerRepository.Save(customer);
                orderRepository.Save(order);

                unitOfWork.Commit();

                return order;
            }
            catch (Exception)
            {
                unitOfWork.Rollback();
                throw;
            }            
        }

        [HttpGet]
        [Route("/GetOrders")]
        public IEnumerable<Order> Get([FromServices]IOrderRepository orderRepository)
        {
            return orderRepository.GetAll().ToArray();
        }
    }
}
