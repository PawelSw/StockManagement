using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Queries.SuppliersQuery
{
    public class GetSuppliersQuery : QueryBase<List<Supplier>>
    {
        public string Name { get; set; }
        public async override Task<List<Supplier>> Execute(StockManagementStorageContext context)
        {
            return context.Suppliers.Where(x => x.Name.Contains(this.Name)).ToList();
        }
    }
}
