using MediatR;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess;
using StockManagement.DataAccess.Entities;


namespace StockManagement.ApplicationServices.API.Handlers
{
   
    public class GetItemsHandler : IRequestHandler<GetItemsRequest, GetItemsResponse>
    {
        private readonly IRepository<Item> itemRepository;
        public GetItemsHandler(IRepository<DataAccess.Entities.Item> itemRepository)
        {
            this.itemRepository = itemRepository;
        }
        public Task<GetItemsResponse> Handle(GetItemsRequest request, CancellationToken cancellationToken)
        {
           var items = this.itemRepository.GetAll();
            var itemsDomain = items.Select(x => new Domain.Models.Item()
            {
                Id = x.Id,
                Name  = x.Name,
            });
            var response = new GetItemsResponse()
            {
                Data = itemsDomain.ToList()
            };

            return Task.FromResult(response);

        }
    }
}
