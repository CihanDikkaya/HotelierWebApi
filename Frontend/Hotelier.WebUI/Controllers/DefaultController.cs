using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
