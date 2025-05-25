using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "İsim bilgisi zorunludur")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Soyisim bilgisi zorunludur")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Mail bilgisi zorunludur")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı girilmelidir")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Şifre bilgisi zorunludur")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar bilgisi zorunludur")]
        public string ConfirmPassword { get; set; }

    }
}
