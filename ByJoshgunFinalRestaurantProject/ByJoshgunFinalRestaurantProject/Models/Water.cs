using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByJoshgunFinalRestaurantProject.Models
{
    public class Water
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public int Price { get; set; }
        public MenuWater MenuWater { get; set; }
        public int MenuWaterId { get; set; }
        public bool IsDeactive { get; set; }

    }
}
