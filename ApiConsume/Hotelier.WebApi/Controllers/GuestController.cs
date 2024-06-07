using Hotelier.BusinessLayer.Abstract;
using Hotelier.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _GuestService;

        public GuestController(IGuestService GuestService)
        {
            _GuestService = GuestService;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var v = _GuestService.TGetList();
            return Ok(v);
        }
        [HttpPost]
        public IActionResult AddGuest(Guest Guest)
        {
            _GuestService.TInsert(Guest);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var v = _GuestService.TGetByID(id);
            _GuestService.TDelete(v);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateGuest(Guest Guest)
        {
            _GuestService.TUpdate(Guest);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var v = _GuestService.TGetByID(id);
            return Ok(v);
        }
    }
}
