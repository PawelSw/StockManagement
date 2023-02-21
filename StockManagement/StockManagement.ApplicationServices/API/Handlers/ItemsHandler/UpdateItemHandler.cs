

using AutoMapper;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess.CORS;
using StockManagement.DataAccess;
using Azure.Core;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;
using StockManagement.DataAccess.CORS.Queries.ItemsQuerry;
using StockManagement.DataAccess.CORS.Commands.ItemCommand;

namespace StockManagement.ApplicationServices.API.Handlers.ItemsHandler
{
    public class UpdateItemHandler : IRequestHandler<UpdateItemRequest, UpdateItemResponse>
    {
   
            private readonly IMapper _mapper;
        private readonly IQueryExecutor _queryExecutor;
        private readonly ICommandExecutor _commandExecutor;

        public UpdateItemHandler(
        IMapper mapper,
        IQueryExecutor queryExecutor,
        ICommandExecutor commandExecutor)
        {
            _mapper = mapper;
            _queryExecutor = queryExecutor;
            _commandExecutor = commandExecutor;
        }
        public async Task<UpdateItemResponse> Handle(UpdateItemRequest request, CancellationToken cancellationToken)
        {
            var query = new GetItemByIdQuery()
            {
                Id = request.UpdateId
            };
            var product = await _queryExecutor.Execute(query);

            //if (product is null)
            //{
            //    return new UpdateProductResponse()
            //    {
            //        Error = new ErrorModel(ErrorType.NotFound)

            //    };
            //}

            var mappedItem = _mapper.Map<DataAccess.Entities.Item>(request);

            var command = new UpdateItemCommand()
            {
                Parameter = mappedItem,
            };

            var updatedItem = await _commandExecutor.Execute(command);

            var response = new UpdateItemResponse()
            {
                Data = _mapper.Map<Domain.Models.Item>(updatedItem)
            };

            return response;

        }
    }
}
