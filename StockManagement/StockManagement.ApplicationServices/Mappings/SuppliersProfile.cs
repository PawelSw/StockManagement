using AutoMapper;

namespace StockManagement.ApplicationServices.Mappings
{
    public class SuppliersProfile : Profile
    {
        public SuppliersProfile()
        {
            this.CreateMap<DataAccess.Entities.Supplier, API.Domain.Models.Supplier>()
            .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
            .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));
        }
    }
}
