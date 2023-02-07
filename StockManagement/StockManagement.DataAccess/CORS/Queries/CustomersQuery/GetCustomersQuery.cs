using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Queries.CustomersQuery
{
    public class GetCustomersQuery : QueryBase<List<Customer>>
    {
        public string Name { get; set; }
        public async override Task<List<Customer>> Execute(StockManagementStorageContext context)
        {
            return context.Customers.Where(x => x.Name.Contains(this.Name)).ToList();
        }
    }
}
