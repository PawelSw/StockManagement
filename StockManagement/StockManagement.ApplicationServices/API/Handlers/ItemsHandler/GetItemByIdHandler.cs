using AutoMapper;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess.CORS.Queries.ItemsQuerry;
using StockManagement.DataAccess;
using MediatR;

namespace StockManagement.ApplicationServices.API.Handlers.ItemsHandler
{
    public class GetItemByIdHandler : IRequestHandler<GetItemByIdRequest, GetItemByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetItemByIdHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;

        }
        public async Task<GetItemByIdResponse> Handle(GetItemByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetItemByIdQuery()
            {
               Id = request.ItemId
            };

            var items = await queryExecutor.Execute(query);
            var mappedItem = mapper.Map<Domain.Models.Item>(items);

            var response = new GetItemByIdResponse()
            {
                Data = mappedItem
            };

            return response;

        }
    }
}
