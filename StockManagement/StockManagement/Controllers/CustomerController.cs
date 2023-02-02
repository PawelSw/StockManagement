using MediatR;
using Microsoft.AspNetCore.Mvc;
using StockManagement.ApplicationServices.API.Domain.CustomerServices;

namespace StockManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator mediator;
        public CustomerController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllCustomers([FromQuery] GetCustomerRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

    }
}
