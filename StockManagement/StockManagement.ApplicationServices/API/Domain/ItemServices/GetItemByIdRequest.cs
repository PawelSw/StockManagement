using MediatR;

namespace StockManagement.ApplicationServices.API.Domain.ItemServices
{
    public class GetItemByIdRequest : IRequest<GetItemByIdResponse>
    {
        public int ItemId { get; set; }
    }
}
