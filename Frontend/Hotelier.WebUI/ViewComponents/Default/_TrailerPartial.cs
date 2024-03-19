using Microsoft.AspNetCore.Mvc;
namespace Hotelier.WebUI.ViewComponents.Default
{
    public class _TrailerPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
