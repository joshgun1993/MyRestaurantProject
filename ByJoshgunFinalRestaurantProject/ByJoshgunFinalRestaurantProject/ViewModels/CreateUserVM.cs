using System.ComponentModel.DataAnnotations;

namespace ByJoshgunFinalRestaurantProject.ViewModels
{
    public class CreateUserVM
    {
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        [DataType(DataType.Password, ErrorMessage = "Şifrələr fərqli ola bilməz."), Compare("Password")]
        public string CheckPassword { get; set; }
    }
}
