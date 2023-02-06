using StockManagement.DataAccess.CORS.Commands;

namespace StockManagement.DataAccess.CORS
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly StockManagementStorageContext context;

        public CommandExecutor(StockManagementStorageContext context)
        {
            this.context = context;
        }

        public Task<TResult> Execute<TParameters, TResult>(CommandBase<TParameters, TResult> command)
        {
            return command.Execute(this.context);
        }
    }
}
