using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ByJoshgunFinalRestaurantProject.Models
{
    public class Expenditure
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public string AboutPrice { get; set; }
        public DateTime? ExpenditureTime { get; set; }
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }
    }
}
