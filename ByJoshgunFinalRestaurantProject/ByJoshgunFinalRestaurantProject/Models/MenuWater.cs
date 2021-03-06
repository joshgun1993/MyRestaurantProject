using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ByJoshgunFinalRestaurantProject.Models
{
    public class MenuWater
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public string Name { get; set; }
        public bool IsDeactive { get; set; }
        public List<Water> Water { get; set; }
    }
}
