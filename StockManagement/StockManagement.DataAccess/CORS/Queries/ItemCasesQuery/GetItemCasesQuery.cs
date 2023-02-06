using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Queries.ItemCasesQuery
{
    public class GetItemCasesQuery : QueryBase<List<ItemCase>>
    {
        public override Task<List<ItemCase>> Execute(StockManagementStorageContext context)
        {
            return context.ItemCases.ToListAsync();
        }

    }
}
