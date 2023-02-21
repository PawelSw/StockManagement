using AutoMapper;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess.CORS.Queries.ItemsQuerry;
using StockManagement.DataAccess;
using MediatR;
using StockManagement.ApplicationServices.API.ErrorHandling;

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

            var item = await queryExecutor.Execute(query);

            if (item is null)
            {
                return new GetItemByIdResponse()
                {
                    Error = new ErrorModel(ErrorType.NotFound)
                };
            }

            var mappedItem = mapper.Map<Domain.Models.Item>(item);

            var response = new GetItemByIdResponse()
            {
                Data = mappedItem
            };

            return response;

        }
    }
}
