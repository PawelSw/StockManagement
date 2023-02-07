using AutoMapper;
using StockManagement.ApplicationServices.API.Domain.ItemServices;

namespace StockManagement.ApplicationServices.Mappings
{
    public class ItemsProfile : Profile
    {
        public ItemsProfile()
        {
            this.CreateMap<AddItemRequest, DataAccess.Entities.Item>()
            .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));
            // .ForMember(x => x.Category, y => y.MapFrom(z => z.Category));

            this.CreateMap<DataAccess.Entities.Item, API.Domain.Models.Item>()
          .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
          .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));
             // .ForMember(x => x.Category, y => y.MapFrom(z => z.Category));
        }
    }
}
