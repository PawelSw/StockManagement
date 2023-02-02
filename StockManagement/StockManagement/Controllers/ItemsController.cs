﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
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

    }

      
    
}
