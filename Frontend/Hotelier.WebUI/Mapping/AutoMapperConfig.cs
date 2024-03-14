using AutoMapper;
using Hotelier.EntityLayer.Concrete;
using Hotelier.WebUI.DTOS.LoginDTO;
using Hotelier.WebUI.DTOS.RegisterDTO;
using Hotelier.WebUI.DTOS.ServiceDTO;

namespace Hotelier.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDTO, Service>().ReverseMap();
            CreateMap<UpdateServiceDTO, Service>().ReverseMap();
            CreateMap<CreateServiceDTO, Service>().ReverseMap();
            CreateMap<CreateNewUserDTO, AppUser>().ReverseMap();
            CreateMap<LoginUserDTO, AppUser>().ReverseMap();
        }
    }
}
