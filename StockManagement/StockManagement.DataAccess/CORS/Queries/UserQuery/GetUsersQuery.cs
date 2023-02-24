using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.DataAccess.CORS.Queries.UserQuery
{
    public class GetUsersQuery : QueryBase<List<User>>
    {
        public async override Task<List<User>> Execute(StockManagementStorageContext context)
        {
            var users = await context.Users.ToListAsync();
            return users;
        }
    }

}
