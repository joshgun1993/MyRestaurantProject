using System.ComponentModel.DataAnnotations;

namespace ByJoshgunFinalRestaurantProject.ViewModels
{
    public class ForgotPasswordVM
    {
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
