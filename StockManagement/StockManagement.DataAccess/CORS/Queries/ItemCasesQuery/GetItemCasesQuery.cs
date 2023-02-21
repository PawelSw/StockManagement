using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;
using System.Collections.Generic;


namespace StockManagement.DataAccess.CORS.Queries.ItemCasesQuery
{
    public class GetItemCasesQuery : QueryBase<List<ItemCase>>
    {
        public override Task<List<ItemCase>> Execute(StockManagementStorageContext context)
        {
            return context.ItemCases
               .Include(x => x.Items)
                .ToListAsync();
        }

    }
}
