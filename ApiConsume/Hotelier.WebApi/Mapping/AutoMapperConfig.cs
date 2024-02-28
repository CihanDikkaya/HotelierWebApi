using AutoMapper;
using Hotelier.DTOLayer.DTOS.RoomDTO;
using Hotelier.EntityLayer.Concrete;

namespace Hotelier.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDTO, Room>();
            CreateMap<Room, RoomAddDTO>();

            CreateMap<UpdateRoomDTO,Room>().ReverseMap();

        }
    }
}
