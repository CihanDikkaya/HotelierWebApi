using Microsoft.AspNetCore.Mvc;
namespace Hotelier.WebUI.ViewComponents.Default
{
    public class _RoomPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
