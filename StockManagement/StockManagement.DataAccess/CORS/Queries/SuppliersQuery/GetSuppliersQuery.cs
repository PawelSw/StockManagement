using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Queries.SuppliersQuery
{
    public class GetSuppliersQuery : QueryBase<List<Supplier>>
    {
        public override Task<List<Supplier>> Execute(StockManagementStorageContext context)
        {
            return context.Suppliers.ToListAsync();
        }
    }
}
