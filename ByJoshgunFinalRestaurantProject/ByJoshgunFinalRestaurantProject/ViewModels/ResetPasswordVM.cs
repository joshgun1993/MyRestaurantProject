using System.ComponentModel.DataAnnotations;

namespace ByJoshgunFinalRestaurantProject.ViewModels
{
    public class ResetPasswordVM
    {
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password),Compare(nameof(Password))]
        public string CheckPassword { get; set; }
        public string Token { get; set; }
        
    }
}
