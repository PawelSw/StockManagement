
using MediatR;

namespace StockManagement.ApplicationServices.API.Domain.ItemServices
{
    public class UpdateItemRequest : IRequest<UpdateItemResponse>
    {
        public int UpdateId { get; set; }
    }
}
