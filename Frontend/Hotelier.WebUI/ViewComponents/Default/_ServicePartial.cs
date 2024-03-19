using Microsoft.AspNetCore.Mvc;
namespace Hotelier.WebUI.ViewComponents.Default
{
    public class _ServicePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
