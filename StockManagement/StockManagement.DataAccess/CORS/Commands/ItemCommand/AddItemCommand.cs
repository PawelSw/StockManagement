using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Commands.AddItemCommand
{
    public class AddItemCommand : CommandBase<Item,Item>
    {
        public override async Task<Item> Execute(StockManagementStorageContext context)
        {
            await context.Items.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return Parameter;
        }
    }     
}
