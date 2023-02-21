using MediatR;
using Microsoft.AspNetCore.Mvc;
using StockManagement.ApplicationServices.API.Domain.ItemCaseServices;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using Microsoft.Extensions.Logging;

namespace StockManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ApiControllerBase
    {
        public ItemsController(IMediator mediator, ILogger<ItemsController> logger) : base(mediator) 
        {
            logger.LogInformation("We are in items.");
        }

        [HttpGet]
        [Route("")]
        public  Task<IActionResult> GetAllItems([FromQuery] GetItemsRequest request)
        {
            //var response = await this.mediator.Send(request);
            //return this.Ok(response);
            return this.HandleRequest<GetItemsRequest, GetItemsResponse>(request);
        }

        [HttpGet]
        [Route("{itemId}")]
        public Task<IActionResult> GetItemById([FromRoute] int itemId)
        {
            var request = new GetItemByIdRequest()
            {
                ItemId = itemId
            };
            //var response = await this.mediator.Send(request);
            //return this.Ok(response);
            return this.HandleRequest<GetItemByIdRequest, GetItemByIdResponse>(request);
        }


        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddItem([FromBody] AddItemRequest request)
        {

            //var response = await this.mediator.Send(request);
            //return this.Ok(response);


            return this.HandleRequest<AddItemRequest, AddItemResponse>(request);
        }
        [HttpDelete]
        [Route("{id}")]
        public Task<IActionResult> DeleteItem([FromRoute] int id)
        {
           
            var request = new DeleteItemRequest()
            {
                DeleteId = id
            };
            ////var response = await this.mediator.Send(request);
            ////return this.Ok(response);
            return this.HandleRequest<DeleteItemRequest, DeleteItemResponse>(request);
        }
        //[HttpPut]
        //[Route("{id}")]
        //public async Task<IActionResult> UpdateProductById([FromRoute] int id, [FromBody] UpdateItemRequest request)
        //{
        //    request.UpdateId = id;
        //    var response = await this.mediator.Send(request);
        //    return this.Ok(response);
        //}

    }

      
    
}

