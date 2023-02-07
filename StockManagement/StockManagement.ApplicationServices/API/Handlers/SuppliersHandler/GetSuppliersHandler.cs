using AutoMapper;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.ApplicationServices.API.Domain.SupplierServices;
using StockManagement.DataAccess;
using StockManagement.DataAccess.CORS.Queries.ItemsQuerry;
using StockManagement.DataAccess.CORS.Queries.SuppliersQuery;

namespace StockManagement.ApplicationServices.API.Handlers.SuppliersHandler
{
    public class GetSuppliersHandler : IRequestHandler<GetSupplierRequest, GetSupplierResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetSuppliersHandler(IMapper mapper, IQueryExecutor queryExecutor)
        { 
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;

        }
        public async Task<GetSupplierResponse> Handle(GetSupplierRequest request, CancellationToken cancellationToken)
        {
            var query = new GetSuppliersQuery()
            {
                Name = request.Name
            };

            var items = await queryExecutor.Execute(query);
            var mappedItems = mapper.Map<List<Domain.Models.Supplier>>(items);

            var response = new GetSupplierResponse()
            {
                Data = mappedItems
            };

            return response;
        }
    }
}