using System.ComponentModel.DataAnnotations;

namespace UdemyCore_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {

        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Resim url değeri Girin")]
        public string ImageUrl { get; set; }






        [Required(ErrorMessage ="Lütfen Kullanıcı Adı Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen şifreyi girin")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Lütfen şifreyi tekrar girin")]
        [Compare("Password", ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Lütfen mail girin")]
        public string Mail { get; set; }
    }
}
