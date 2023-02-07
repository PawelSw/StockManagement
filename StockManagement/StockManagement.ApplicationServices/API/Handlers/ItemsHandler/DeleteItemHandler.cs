using AutoMapper;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess.CORS;
using StockManagement.DataAccess;
using StockManagement.DataAccess.CORS.Queries.ItemsQuerry;
using StockManagement.DataAccess.CORS.Commands.ItemCommand;

namespace StockManagement.ApplicationServices.API.Handlers.ItemsHandler
{
    public class DeleteItemHandler : IRequestHandler<DeleteItemRequest, DeleteItemResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICommandExecutor _commandExecutor;
        private readonly IQueryExecutor _queryExecutor;

        public DeleteItemHandler(IMapper mapper,
            ICommandExecutor commandExecutor,
            IQueryExecutor queryExecutor)
        {
            _mapper = mapper;
            _commandExecutor = commandExecutor;
            _queryExecutor = queryExecutor;
        }
        public async Task<DeleteItemResponse> Handle(DeleteItemRequest request, CancellationToken cancellationToken)
        {
            var query = new GetItemByIdQuery()
            {
                Id = request.DeleteId
            };
            var product = await _queryExecutor.Execute(query);

            //if (product is null)
            //{
            //    return new DeleteProductResponse()
            //    {
            //        Error = new ErrorModel(ErrorType.NotFound)
            //    };
            //}

            var mappeditem = _mapper.Map<DataAccess.Entities.Item>(request);
            var command = new DeleteItemCommand()
            {
                Parameter = mappeditem
            };
            var deleteItem = await _commandExecutor.Execute(command);
            var response = new DeleteItemResponse()
            {
                Data = _mapper.Map<Domain.Models.Item>(deleteItem)
            };
            return response;
        }
    }
}
