using System.ComponentModel.DataAnnotations;

namespace ByJoshgunFinalRestaurantProject.ViewModels
{
    public class UpdateUserVM
    {
        
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Zəhmət olmasa doğru email daxil edin")]
        public string Email { get; set; }

    }
}
