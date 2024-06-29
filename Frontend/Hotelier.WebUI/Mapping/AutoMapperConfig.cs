using AutoMapper;
using Hotelier.EntityLayer.Concrete;
using Hotelier.WebUI.DTOS.AboutDTO;
using Hotelier.WebUI.DTOS.BookingDTO;
using Hotelier.WebUI.DTOS.GuestDTO;
using Hotelier.WebUI.DTOS.LoginDTO;
using Hotelier.WebUI.DTOS.RegisterDTO;
using Hotelier.WebUI.DTOS.ServiceDTO;
using Hotelier.WebUI.DTOS.StaffDTO;
using Hotelier.WebUI.DTOS.SubscribeDTO;
using Hotelier.WebUI.DTOS.TestimonialDTO;

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
            CreateMap<ResultAboutDTO, About>().ReverseMap();
            CreateMap<UpdateAboutDTO, About>().ReverseMap();
            CreateMap<ResultTestimonialDTO, Testimonial>().ReverseMap();
            CreateMap<ResultStaffDTO, Staff>().ReverseMap();
            CreateMap<CreateSubsDTO, Subscribe>().ReverseMap();
            CreateMap<CreateBookingDTO, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDTO, Booking>().ReverseMap();
            CreateMap<CreateGuestDTO, Guest>().ReverseMap();
            CreateMap<UpdateGuestDTO, Guest>().ReverseMap();

        }
    }
}
