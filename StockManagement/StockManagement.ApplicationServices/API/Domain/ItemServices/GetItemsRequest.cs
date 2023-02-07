using MediatR;

namespace StockManagement.ApplicationServices.API.Domain.ItemServices
{
    public class GetItemsRequest : IRequest<GetItemsResponse>
    {
      public string Name { get; set; }
    }
}
