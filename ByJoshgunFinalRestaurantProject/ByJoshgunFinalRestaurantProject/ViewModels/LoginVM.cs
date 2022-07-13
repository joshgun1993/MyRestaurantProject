using System.ComponentModel.DataAnnotations;

namespace ByJoshgunFinalRestaurantProject.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Zəhmət olmasa doğru email daxil edin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz"), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
