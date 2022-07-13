using System;
using System.ComponentModel.DataAnnotations;

namespace ByJoshgunFinalRestaurantProject.Models
{
    public class Income
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public string AboutPrice { get; set; }
        public DateTime? IncomesTime { get; set; }
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }

    }
}
