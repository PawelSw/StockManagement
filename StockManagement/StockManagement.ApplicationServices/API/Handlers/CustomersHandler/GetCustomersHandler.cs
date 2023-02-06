using AutoMapper;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.CustomerServices;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess;
using StockManagement.DataAccess.CORS.Queries.CustomersQuery;
using StockManagement.DataAccess.CORS.Queries.ItemsQuerry;
using StockManagement.DataAccess.Entities;

namespace StockManagement.ApplicationServices.API.Handlers.CustomersHandler
{
    public class GetCustomersHandler : IRequestHandler<GetCustomerRequest, GetCustomerResponse>
    {
        // private readonly IRepository<Customer> customerRepository;
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetCustomersHandler( IQueryExecutor queryExecutor, IMapper mapper)
        {
            // this.customerRepository = customerRepository;
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;
            
        }
        public async Task<GetCustomerResponse> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
        {
      
            var query = new GetCustomersQuery();
            var customers = await queryExecutor.Execute(query);
            // var items = await this.itemRepository.GetAll();
            var mappedCustomers = mapper.Map<List<Domain.Models.Customer>>(customers);

            var response = new GetCustomerResponse()
            {
                Data = mappedCustomers
            };

            return response;

        }
    }
}

