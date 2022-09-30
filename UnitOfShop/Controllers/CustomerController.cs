using Microsoft.AspNetCore.Mvc;
using UnitOfShop.Models;
using UnitOfShop.Repositories.Interface;

namespace UnitOfShop.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IEnumerable<Customer> Get([FromServices]ICustomerRepository customerRepository)
        {
            return customerRepository.GetAll().ToArray();
        }
    }
}
