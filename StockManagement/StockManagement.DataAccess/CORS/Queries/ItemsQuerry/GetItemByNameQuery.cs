using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;
using System.Security.Cryptography.X509Certificates;

namespace StockManagement.DataAccess.CORS.Queries.ItemsQuerry
{
    public class GetItemByNameQuery : QueryBase<List<Item>>
    {
        public string Name { get; set; }
        public async override Task<List<Item>> Execute(StockManagementStorageContext context)
        {
            //if (string.IsNullOrWhiteSpace(Title))
            //{
            //    return context.Books.ToListAsync();
            //}
            //else
            //{
            //var item = await context.Items.FirstOrDefaultAsync(x => x.Name == this.Name);
            return context.Items.Where(x => x.Name.Contains(this.Name)).ToList();
        }
    }
}
