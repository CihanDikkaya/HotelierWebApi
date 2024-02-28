using AutoMapper;
using Hotelier.BusinessLayer.Abstract;
using Hotelier.DTOLayer.DTOS.RoomDTO;
using Hotelier.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService roomService;
        private readonly IMapper mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            this.roomService = roomService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var val = roomService.TGetList();
            return Ok(val);

        }

        [HttpPost]
        public IActionResult AddRoom(RoomAddDTO roomAddDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var val = mapper.Map<Room>(roomAddDTO);
            roomService.TInsert(val);
            return Ok(val);
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDTO updateRoomDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var val = mapper.Map<Room>(updateRoomDTO);
            roomService.TUpdate(val);
            return Ok("Başarıyla Güncellendi");

        }
    }
}
