using MediatR;
using StockManagement.ApplicationServices.API.Domain.ItemCaseServices;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess;
using StockManagement.DataAccess.Entities;

namespace StockManagement.ApplicationServices.API.Handlers
{
    public class GetItemCaseHandler : IRequestHandler<GetItemCaseRequest, GetItemCaseResponse>
    {
        private readonly IRepository<ItemCase> itemCaseRepository;
        public GetItemCaseHandler(IRepository<DataAccess.Entities.ItemCase> itemCaseRepository)
        {
            this.itemCaseRepository = itemCaseRepository;
        }
        public Task<GetItemCaseResponse> Handle(GetItemCaseRequest request, CancellationToken cancellationToken)
        {
            var items = this.itemCaseRepository.GetAll();
            var itemsDomain = items.Select(x => new Domain.Models.ItemCase()
            {
                Id = x.Id,
                Number = x.Number,

            });
            var response = new GetItemCaseResponse()
            {
                Data = itemsDomain.ToList()
            };

            return Task.FromResult(response);

        }
    }
}
