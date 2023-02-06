using AutoMapper;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.SupplierServices;
using StockManagement.DataAccess;
using StockManagement.DataAccess.CORS.Queries.SuppliersQuery;

namespace StockManagement.ApplicationServices.API.Handlers.SuppliersHandler
{
    public class GetSuppliersHandler : IRequestHandler<GetSupplierRequest, GetSupplierResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetSuppliersHandler(IMapper mapper, IQueryExecutor queryExecutor)
        { 
            // this.itemRepository = itemRepository;
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;

        }
        public async Task<GetSupplierResponse> Handle(GetSupplierRequest request, CancellationToken cancellationToken)
        {
            var query = new GetSuppliersQuery();
            var suppliers = await queryExecutor.Execute(query);
            // var items = await this.itemRepository.GetAll();
            var mappedSuppliers = mapper.Map<List<Domain.Models.Supplier>>(suppliers);

            var response = new GetSupplierResponse()
            {
                Data = mappedSuppliers
            };

            return response;
        }
    }
}