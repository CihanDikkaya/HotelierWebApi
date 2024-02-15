using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
