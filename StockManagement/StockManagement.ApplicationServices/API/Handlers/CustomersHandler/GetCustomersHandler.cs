using AutoMapper;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.CustomerServices;
using StockManagement.DataAccess;
using StockManagement.DataAccess.CORS.Queries.CustomersQuery;
using StockManagement.DataAccess.Entities;

namespace StockManagement.ApplicationServices.API.Handlers.CustomersHandler
{
    public class GetCustomersHandler : IRequestHandler<GetCustomerRequest, GetCustomerResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetCustomersHandler( IQueryExecutor queryExecutor, IMapper mapper)
        {
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;         
        }
        public async Task<GetCustomerResponse> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
        {
            var query = new GetCustomersQuery()
            {
                Name = request.Name
            };

            var items = await queryExecutor.Execute(query);
            var mappedItems = mapper.Map<List<Domain.Models.Customer>>(items);

            var response = new GetCustomerResponse()
            {
                Data = mappedItems
            };

            return response;
        }
    }
}

