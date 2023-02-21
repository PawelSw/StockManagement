using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Queries.UserQuery
{
    public class GetUserQuery : QueryBase<List<User>>
    {
        public string UserName { get; set; }
        public override async Task<List<User>> Execute(StockManagementStorageContext context)
        {
          //return  context.Users.FirstOrDefault(x => x.UserName == this.UserName);
           return context.Users.ToList();


        }
    }
}
