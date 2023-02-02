using AutoMapper;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess;
using StockManagement.DataAccess.Entities;


namespace StockManagement.ApplicationServices.API.Handlers
{

    public class GetItemsHandler : IRequestHandler<GetItemsRequest, GetItemsResponse>
    {
        private readonly IRepository<Item> itemRepository;
        private readonly IMapper mapper;
        public GetItemsHandler(IRepository<DataAccess.Entities.Item> itemRepository, IMapper mapper)
        {
            this.itemRepository = itemRepository;
            this.mapper = mapper;
        }
        public Task<GetItemsResponse> Handle(GetItemsRequest request, CancellationToken cancellationToken)
        {
            var items = this.itemRepository.GetAll();
            var mappedItems = this.mapper.Map<List<Domain.Models.Item>>(items);

            var response = new GetItemsResponse()
            {
                Data = mappedItems
            };

            return Task.FromResult(response);

        }
    }
}
