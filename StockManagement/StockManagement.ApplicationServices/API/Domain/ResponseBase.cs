using StockManagement.ApplicationServices.API.ErrorHandling;

namespace StockManagement.ApplicationServices.API.Domain
{
    public class ResponseBase<T> : ErrorResponseBase
    {
        public T Data { get; set; }
    }
}
