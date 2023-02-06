using AutoMapper;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess;
using StockManagement.DataAccess.CORS.Queries.ItemsQuerry;
using StockManagement.DataAccess.Entities;


namespace StockManagement.ApplicationServices.API.Handlers.ItemsHandler
{

    public class GetItemsHandler : IRequestHandler<GetItemsRequest, GetItemsResponse>
    {
        // private readonly IRepository<Item> itemRepository;
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetItemsHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            // this.itemRepository = itemRepository;
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;

        }
        public async Task<GetItemsResponse> Handle(GetItemsRequest request, CancellationToken cancellationToken)
        {
            var query = new GetItemsQuery();
            var items = await queryExecutor.Execute(query);
            // var items = await this.itemRepository.GetAll();
            var mappedItems = mapper.Map<List<Domain.Models.Item>>(items);

            var response = new GetItemsResponse()
            {
                Data = mappedItems
            };

            return response;

        }
    }
}
