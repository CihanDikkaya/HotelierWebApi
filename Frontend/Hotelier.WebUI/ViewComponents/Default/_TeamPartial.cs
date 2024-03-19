using Microsoft.AspNetCore.Mvc;
namespace Hotelier.WebUI.ViewComponents.Default
{
    public class _TeamPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
