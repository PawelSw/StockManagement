using AutoMapper;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess.CORS.Queries.ItemsQuerry;
using StockManagement.DataAccess;

namespace StockManagement.ApplicationServices.API.Handlers.ItemsHandler
{
    public class GetItemByNameHandler : IRequestHandler<GetItemByNameRequest, GetItemByNameResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetItemByNameHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
  
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;

        }
        public async Task<GetItemByNameResponse> Handle(GetItemByNameRequest request, CancellationToken cancellationToken)
        {
            var query = new GetItemByNameQuery()
            {
                Name = request.Name
            };
            
            var items = await queryExecutor.Execute(query);
            var mappedItems = mapper.Map<List<Domain.Models.Item>>(items);

            var response = new GetItemByNameResponse()
            {
                Data = mappedItems
            };

            return response;

        }
    }
}

