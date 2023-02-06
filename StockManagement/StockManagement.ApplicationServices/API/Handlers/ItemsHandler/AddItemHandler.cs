using AutoMapper;
using StockManagement.ApplicationServices.API.Domain.ItemServices;
using StockManagement.DataAccess.CORS;
using StockManagement.DataAccess.Entities;
using StockManagement.DataAccess.CORS.Commands.AddItemCommand;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.ItemCaseServices;

namespace StockManagement.ApplicationServices.API.Handlers.ItemsHandler
{
    public class AddItemHandler : IRequestHandler<AddItemRequest, AddItemResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public AddItemHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<AddItemResponse> Handle(AddItemRequest request, CancellationToken cancellationToken)
        {
            var item = this.mapper.Map<Item>(request);
            var command = new AddItemCommand() { Parameter = item};
            var itemFromDb = await this.commandExecutor.Execute(command);
            return new AddItemResponse()
            {
                Data = this.mapper.Map<Domain.Models.Item>(itemFromDb)
            };

        }
    }
}

