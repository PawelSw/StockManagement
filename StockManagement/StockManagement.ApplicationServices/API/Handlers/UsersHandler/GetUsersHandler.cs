using AutoMapper;
using MediatR;
using StockManagement.ApplicationServices.API.Domain.UserServices;
using StockManagement.DataAccess;
using StockManagement.DataAccess.CORS.Queries.UserQuery;
using StockManagement.DataAccess.Entities;

namespace StockManagement.ApplicationServices.API.Handlers.ItemCasesHandler
{
    public class GetUsersHandler : IRequestHandler<GetUserRequest, GetUserResponse>
    {
      
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetUsersHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;

        }
        public async Task<GetUserResponse> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var query = new GetUserQuery();
            var users = await queryExecutor.Execute(query);
            var mappedUsers = mapper.Map<List<Domain.Models.User>>(users);

            var response = new GetUserResponse()
            {
                Data = mappedUsers
            };

            return response;

        }
    }
}
