using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Queries.ItemsQuerry
{
    public class GetItemByIdQuery : QueryBase<Item>
    {
        public int Id { get; set; }
        public override async Task<Item> Execute(StockManagementStorageContext context)
        {
           var item = await context.Items.FirstOrDefaultAsync(x => x.Id == this.Id);
            return item;
        }
    }
}
