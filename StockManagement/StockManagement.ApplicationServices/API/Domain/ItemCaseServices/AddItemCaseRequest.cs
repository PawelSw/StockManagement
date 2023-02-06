using MediatR;

namespace StockManagement.ApplicationServices.API.Domain.ItemCaseServices
{
    public class AddItemCaseRequest : IRequest<AddItemCaseResponse>
    {
        public int Number { get; set; }
    }
}
