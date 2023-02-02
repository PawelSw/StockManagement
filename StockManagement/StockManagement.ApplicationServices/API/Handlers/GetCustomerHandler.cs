using MediatR;
using StockManagement.ApplicationServices.API.Domain.CustomerServices;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess;
using StockManagement.DataAccess.Entities;

namespace StockManagement.ApplicationServices.API.Handlers
{
    public class GetCustomerHandler : IRequestHandler<GetCustomerRequest, GetCustomerResponse>
    {
        private readonly IRepository<Customer> customerRepository;
        public GetCustomerHandler(IRepository<DataAccess.Entities.Customer> customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public Task<GetCustomerResponse> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
        {
            var items = this.customerRepository.GetAll();
            var itemsDomain = items.Select(x => new Domain.Models.Customer()
            {
                Id = x.Id,
                Name = x.Name,
                Address= x.Address,
            });
            var response = new GetCustomerResponse()
            {
                Data = itemsDomain.ToList()
            };

            return Task.FromResult(response);

        }
    }
}

