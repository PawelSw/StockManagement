using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Queries.CustomersQuery
{
    public class GetCustomersQuery : QueryBase<List<Customer>>
    {
        public override Task<List<Customer>> Execute(StockManagementStorageContext context)
        {
            return context.Customers.ToListAsync();
        }
    }
}
