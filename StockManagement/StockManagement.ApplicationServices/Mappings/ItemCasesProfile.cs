using AutoMapper;
using StockManagement.ApplicationServices.API.Domain.ItemCaseServices;


namespace StockManagement.ApplicationServices.Mappings
{
    public class ItemCasesProfile : Profile
    {
        public ItemCasesProfile()
        {
            this.CreateMap<AddItemCaseRequest, DataAccess.Entities.ItemCase>()

            .ForMember(x => x.Number, y => y.MapFrom(z => z.Number));


            this.CreateMap<DataAccess.Entities.ItemCase, API.Domain.Models.ItemCase>()
            .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
            .ForMember(x => x.Number, y => y.MapFrom(z => z.Number))
            .ForMember(x => x.ItemNames, y => y.MapFrom(z => z.Items != null ? z.Items.Select(x=>x.Name) : new List<string>()));



        }
    }
}
