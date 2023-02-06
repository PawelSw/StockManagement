using StockManagement.DataAccess.CORS.Queries;

namespace StockManagement.DataAccess
{
    public interface IQueryExecutor
    {
        Task<TResult> Execute<TResult>(QueryBase<TResult> query);
    }
}
