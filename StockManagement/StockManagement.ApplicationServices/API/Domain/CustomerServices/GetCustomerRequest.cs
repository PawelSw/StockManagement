using MediatR;

namespace StockManagement.ApplicationServices.API.Domain.CustomerServices
{
    public class GetCustomerRequest : IRequest<GetCustomerResponse>
    {
        public string Name { get; set; }
    }
}
