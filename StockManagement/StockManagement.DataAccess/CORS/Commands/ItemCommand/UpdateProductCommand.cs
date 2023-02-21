using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Commands.ItemCommand
{
    public class UpdateItemCommand : CommandBase<Item, Item>
    {
        public override async Task<Item> Execute(StockManagementStorageContext context)
        {
            context.ChangeTracker.Clear();
            context.Items.Update(Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
