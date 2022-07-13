using System;
using System.ComponentModel.DataAnnotations;

namespace ByJoshgunFinalRestaurantProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        public int Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Zəhmət olmasa doğru email daxil edin")]
        public string Email { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }
        public bool IsDeactive { get; set; }
    }
}
