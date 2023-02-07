﻿using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Queries.ItemsQuerry
{
    public class GetItemsQuery : QueryBase<List<Item>>
    {
        public string Name { get; set; }
        public async override Task<List<Item>> Execute(StockManagementStorageContext context)
        {
            //if (string.IsNullOrWhiteSpace(Name))
            //{
            //    return context.Items.ToList();
            //}
            //else
            //{
            //var item = await context.Items.FirstOrDefaultAsync(x => x.Name == this.Name);
            return context.Items.Where(x => x.Name.Contains(this.Name)).ToList();
        }
    }
}

