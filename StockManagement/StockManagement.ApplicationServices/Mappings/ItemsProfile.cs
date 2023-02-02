using AutoMapper;
using StockManagement.ApplicationServices.API.Domain.Models;

namespace StockManagement.ApplicationServices.Mappings
{
    public class ItemsProfile : Profile
    {
        public ItemsProfile()
        {
            this.CreateMap<DataAccess.Entities.Item, Item>()
            .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
            .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));
        }
    }
}
