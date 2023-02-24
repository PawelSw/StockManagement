using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StockManagement.ApplicationServices.API.Domain.UserServices;

namespace StockManagement.Controllers
{
 
        [Authorize]
        [ApiController]
        [Route("[controller]")]
        public class UsersController : ApiControllerBase
        {
            public UsersController(IMediator mediator)
                : base(mediator)
            {            
            }

         // [AllowAnonymous]
            [HttpGet]
            [Route("")]
            public Task<IActionResult> GetAllUsers([FromQuery] GetUserRequest request)
            {
                return this.HandleRequest<GetUserRequest, GetUserResponse>(request);
            }
        }
}

