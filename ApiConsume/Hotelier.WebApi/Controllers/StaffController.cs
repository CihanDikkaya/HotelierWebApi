using Hotelier.BusinessLayer.Abstract;
using Hotelier.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var v = _staffService.TGetList();
            return Ok(v);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TInsert(staff);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var v = _staffService.TGetByID(id);
            _staffService.TDelete(v);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var v = _staffService.TGetByID(id);
            return Ok(v);
        }
    }
}
