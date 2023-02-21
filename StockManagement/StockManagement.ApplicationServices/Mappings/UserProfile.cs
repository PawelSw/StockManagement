using AutoMapper;

namespace StockManagement.ApplicationServices.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            this.CreateMap<DataAccess.Entities.User, API.Domain.Models.User>()
           .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
           .ForMember(x => x.FirstName, y => y.MapFrom(z => z.FirstName))
           .ForMember(x => x.LastName, y => y.MapFrom(z => z.LastName));
          
        }
    }
}
