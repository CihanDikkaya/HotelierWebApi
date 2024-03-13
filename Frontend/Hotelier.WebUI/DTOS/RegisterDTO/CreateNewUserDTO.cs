using System.ComponentModel.DataAnnotations;

namespace Hotelier.WebUI.DTOS.RegisterDTO
{
    public class CreateNewUserDTO
    {
        [Required(ErrorMessage ="Ad Alanı gereklidir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı gereklidir.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Alanı gereklidir.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "E-Posta Alanı gereklidir.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Alanı gereklidir.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Alanı gereklidir.")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string ConfirPassword { get; set; }

    }
}
