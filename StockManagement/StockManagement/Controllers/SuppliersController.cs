using MediatR;
using Microsoft.AspNetCore.Mvc;
using StockManagement.ApplicationServices.API.Domain.SupplierServices;

namespace StockManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SuppliersController : ControllerBase
    {
        private readonly IMediator mediator;
        public SuppliersController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllSuppliers([FromQuery] GetSupplierRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

    }
}
