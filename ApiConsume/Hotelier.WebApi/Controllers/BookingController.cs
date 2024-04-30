using Hotelier.BusinessLayer.Abstract;
using Hotelier.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult bookingList()
        {
            var v = _bookingService.TGetList();
            return Ok(v);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking  booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var v = _ServiceService.TGetByID(id);
            _ServiceService.TDelete(v);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service Service)
        {
            _ServiceService.TUpdate(Service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var v = _ServiceService.TGetByID(id);
            return Ok(v);
        }
    }
}
