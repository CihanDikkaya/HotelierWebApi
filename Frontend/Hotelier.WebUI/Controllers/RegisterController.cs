using Hotelier.EntityLayer.Concrete;
using Hotelier.WebUI.DTOS.RegisterDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotelier.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDTO createNewUserDTO)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var appUser = new AppUser()
            {
                Name = createNewUserDTO.Name,
                Email = createNewUserDTO.Mail,
                Surname = createNewUserDTO.Surname,
                UserName = createNewUserDTO.Username

            };

            var result = await _userManager.CreateAsync(appUser, createNewUserDTO.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }


            return View();
        }
    }
}
