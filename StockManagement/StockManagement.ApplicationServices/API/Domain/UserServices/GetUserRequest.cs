using MediatR;

namespace StockManagement.ApplicationServices.API.Domain.UserServices
{
    public class GetUserRequest : IRequest<GetUserResponse>
    {
       // public string UserName { get; set; }
    }
}
