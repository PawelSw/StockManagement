using MediatR;


namespace StockManagement.ApplicationServices.API.Domain.SupplierServices
{
    public class GetSupplierRequest : IRequest<GetSupplierResponse>
    {
        public string Name { get; set; }
    }
}
