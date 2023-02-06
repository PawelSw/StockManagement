using AutoMapper;
using Azure;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.ItemCaseServices;
using StockManagement.DataAccess.CORS;
using StockManagement.DataAccess.CORS.Commands.ItemCasesCommand;
using StockManagement.DataAccess.Entities;

namespace StockManagement.ApplicationServices.API.Handlers.ItemCasesHandler
{
    public class AddItemCaseHandler : IRequestHandler<AddItemCaseRequest, AddItemCaseResponse>
    {

        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public AddItemCaseHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<AddItemCaseResponse> Handle(AddItemCaseRequest request, CancellationToken cancellationToken)
        {
            var itemCase = this.mapper.Map<ItemCase>(request);
            var command = new AddItemCaseCommand() { Parameter = itemCase };
            var itemCaseFromDb = await this.commandExecutor.Execute(command);
            return new AddItemCaseResponse()
            {
                Data = this.mapper.Map <Domain.Models.ItemCase>(itemCaseFromDb)
            };
           
        }
    }
}
