using AutoMapper;

namespace StockManagement.ApplicationServices.Mappings
{
    public class CustomersProfile : Profile
    {
        public CustomersProfile()
        {
            this.CreateMap<DataAccess.Entities.Customer, API.Domain.Models.Customer>()
            .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
            .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
            .ForMember(x => x.Address, y => y.MapFrom(z => z.Address));
        }
    }
}