using System.ComponentModel.DataAnnotations;

namespace ByJoshgunFinalRestaurantProject.ViewModels
{
    public class UserVM
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Zəhmət olmasa doğru email daxil edin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        public string Role { get; set; }
        public bool IsDeactive { get; set; }
    }
}
