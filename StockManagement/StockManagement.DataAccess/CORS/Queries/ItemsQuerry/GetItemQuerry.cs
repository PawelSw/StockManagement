using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Queries.ItemsQuerry
{
    public class GetItemQuerry : QueryBase<Item>
    {
        public int Id { get; set; }
        public async override Task<Item> Execute(StockManagementStorageContext context)
        {
            var item = await context.Items.FirstOrDefaultAsync(x => x.Id == this.Id);
            return item;

        }
    }
}
