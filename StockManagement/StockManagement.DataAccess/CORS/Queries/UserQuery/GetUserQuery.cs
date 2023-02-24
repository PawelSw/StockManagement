using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Queries.UserQuery
{
    public class GetUserQuery : QueryBase<User>
    {
       public string UserName { get; set; }
        public override Task<User> Execute(StockManagementStorageContext context)
        {
            //    var user = context.Users.First();
            //    return user;


            var user = context.Users.FirstOrDefaultAsync(x => x.UserName == this.UserName);
            return user;



        }
    }
}
