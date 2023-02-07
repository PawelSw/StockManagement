using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Commands.ItemCommand
{
    public class DeleteItemCommand : CommandBase<Item, Item>
    {
        public override async Task<Item> Execute(StockManagementStorageContext context)
        {
            context.ChangeTracker.Clear();
            context.Items.Remove(Parameter);
            await context.SaveChangesAsync();
            return Parameter;

            //context.Products.RemoveRange(Parameter);
            //await context.SaveChangesAsync();
            //return Parameter;
        }
    }
}
