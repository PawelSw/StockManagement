using MediatR;


namespace StockManagement.ApplicationServices.API.Domain.ItemServices
{
    public class AddItemRequest : IRequest<AddItemResponse>
    {
        public string Name { get; set; }
        //public string Category { get; set; }
    }
}
