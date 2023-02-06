using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Queries.ItemsQuerry
{
    public class GetItemsQuery : QueryBase<List<Item>>
    {
        public override Task<List<Item>> Execute(StockManagementStorageContext context)
        {
            return context.Items.ToListAsync();
        }
    }
}
