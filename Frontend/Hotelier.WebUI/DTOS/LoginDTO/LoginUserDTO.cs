using System.ComponentModel.DataAnnotations;

namespace Hotelier.WebUI.DTOS.LoginDTO
{
    public class LoginUserDTO
    {
        [Required(ErrorMessage = "Kullanıcı Adınızı Giriniz.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifreyi Giriniz.")]
        public string Password { get; set; }
    }
}
