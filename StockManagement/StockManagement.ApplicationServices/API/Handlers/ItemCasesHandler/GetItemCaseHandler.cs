using AutoMapper;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.ItemCaseServices;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess;
using StockManagement.DataAccess.CORS.Queries.ItemCasesQuery;
using StockManagement.DataAccess.CORS.Queries.ItemsQuerry;
using StockManagement.DataAccess.Entities;

namespace StockManagement.ApplicationServices.API.Handlers.ItemCasesHandler
{
    public class GetItemCaseHandler : IRequestHandler<GetItemCaseRequest, GetItemCaseResponse>
    {
        //  private readonly IRepository<ItemCase> itemCaseRepository;
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetItemCaseHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
      
        }
        public async Task<GetItemCaseResponse> Handle(GetItemCaseRequest request, CancellationToken cancellationToken)
        {
            var query = new GetItemCasesQuery();
            var itemCases = await queryExecutor.Execute(query);
            var mappedItemCases = mapper.Map<List<Domain.Models.ItemCase>>(itemCases);

            var response = new GetItemCaseResponse()
            {
                Data = mappedItemCases
            };

            return response;

        }
    }
}
