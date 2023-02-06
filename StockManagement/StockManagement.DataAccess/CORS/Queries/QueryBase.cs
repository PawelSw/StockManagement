namespace StockManagement.DataAccess.CORS.Queries
{
    public abstract class QueryBase<TResult>
    {
        public abstract Task<TResult> Execute(StockManagementStorageContext context);
    }
}
