using MediatR;

namespace StockManagement.ApplicationServices.API.Domain.ItemServices
{
    public class GetItemByNameRequest : IRequest<GetItemByNameResponse>
    {
        public string Name { get; set; }
    }
}
