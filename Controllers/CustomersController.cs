// Controllers/CustomersController.cs
using BranchesConflictTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace BranchesConflictTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult GetCustomer()
        {
            return Ok(_customerService.GetCustomerDetails());
        }
    }
}
