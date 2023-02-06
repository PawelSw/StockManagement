using StockManagement.DataAccess.CORS.Commands;

namespace StockManagement.DataAccess.CORS
{
    public interface ICommandExecutor
    {
        Task<TResult> Execute<TParameters, TResult>(CommandBase<TParameters, TResult> command);
    }
}
