using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Queries.ItemsQuerry
{
    public class GetItemsQuery : QueryBase<List<Item>>
    {
        public string Name { get; set; }
        public async override Task<List<Item>> Execute(StockManagementStorageContext context)
        {
            return context.Items.Where(x => x.Name.Contains(this.Name)).ToList();
        }
    }
}

