using StockManagement.DataAccess.CORS.Queries;

namespace StockManagement.DataAccess
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly StockManagementStorageContext context;

        public QueryExecutor(StockManagementStorageContext context)
        {
            this.context = context;
        }
        public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
        {
            return query.Execute(this.context);
        }
    }
}
