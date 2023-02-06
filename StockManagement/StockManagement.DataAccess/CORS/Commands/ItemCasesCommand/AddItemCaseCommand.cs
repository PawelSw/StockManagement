using StockManagement.DataAccess.Entities;

namespace StockManagement.DataAccess.CORS.Commands.ItemCasesCommand
{
    public class AddItemCaseCommand : CommandBase<ItemCase, ItemCase>
    {
        public override async Task<ItemCase> Execute(StockManagementStorageContext context)
        {
            await context.ItemCases.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return Parameter;
        }
    }
}
