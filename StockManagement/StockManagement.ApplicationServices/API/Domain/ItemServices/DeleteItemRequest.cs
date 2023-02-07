using MediatR;

namespace StockManagement.ApplicationServices.API.Domain.ItemServices
{
    public class DeleteItemRequest : IRequest<DeleteItemResponse>
    {
        public int DeleteId { get; set; }
    }
}
