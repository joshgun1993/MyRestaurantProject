using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ByJoshgunFinalRestaurantProject.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public string PositionName { get; set; }
        public List<Employee> Employees { get; set; }
        public bool IsDeactive { get; set; }
    }
}
