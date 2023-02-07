using MediatR;
using Microsoft.AspNetCore.Mvc;
using StockManagement.ApplicationServices.API.Domain.ItemCaseServices;
using StockManagement.ApplicationServices.API.Domain.ItemServices;

namespace StockManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IMediator mediator;
        public ItemsController(IMediator mediator) 
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllItems([FromQuery] GetItemsRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("{itemId}")]
        public async Task<IActionResult> GetItemById([FromRoute] int itemId)
        {
            var request = new GetItemByIdRequest()
            {
                ItemId = itemId
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }





        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddItem([FromBody] AddItemRequest request)
        {

            var response = await this.mediator.Send(request);
            return this.Ok(response);


            //return this.HandleRequest<AddItemCaseRequest, AddItemCaseResponse>(request);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteItem([FromRoute] int id)
        {
           
            var request = new DeleteItemRequest()
            {
                DeleteId = id
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

    }

      
    
}

