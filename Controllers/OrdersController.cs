// Controllers/OrdersController.cs
using BranchesConflictTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace BranchesConflictTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetOrder()
        {
            return Ok(_orderService.GetOrderDetails());
        }
    }
}
