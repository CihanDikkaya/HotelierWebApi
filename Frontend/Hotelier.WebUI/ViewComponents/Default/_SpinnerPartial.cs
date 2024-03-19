using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.ViewComponents.Default
{
    public class _SpinnerPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
