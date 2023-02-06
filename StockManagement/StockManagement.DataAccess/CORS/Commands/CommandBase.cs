namespace StockManagement.DataAccess.CORS.Commands
{
    public abstract class CommandBase<TParameter, TResult>
    {
        public TParameter Parameter { get; set; }

        public abstract Task<TResult> Execute(StockManagementStorageContext context);
    }
}
