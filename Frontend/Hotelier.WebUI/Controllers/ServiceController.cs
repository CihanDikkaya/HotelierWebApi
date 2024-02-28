using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
