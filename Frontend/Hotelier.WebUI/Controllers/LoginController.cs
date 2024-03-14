using Hotelier.EntityLayer.Concrete;
using Hotelier.WebUI.DTOS.LoginDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotelier.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDTO loginUserDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(loginUserDTO.Username, loginUserDTO.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Staff");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
