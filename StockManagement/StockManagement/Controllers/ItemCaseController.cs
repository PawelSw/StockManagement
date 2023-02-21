using MediatR;
using Microsoft.AspNetCore.Mvc;
using StockManagement.ApplicationServices.API.Domain.ItemCaseServices;
using System.Reflection.Metadata.Ecma335;

namespace StockManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemCaseController : ControllerBase
    {
        private readonly IMediator mediator;
        public ItemCaseController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllItemCases([FromQuery] GetItemCaseRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddItemCase([FromBody] AddItemCaseRequest request)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest("Bad request....");
         
            }

            var response = await this.mediator.Send(request);
            return this.Ok(response);


          //  return this.HandleRequest<AddItemCaseRequest, AddItemCaseResponse>(request);
        }

    }
}
