using System.ComponentModel.DataAnnotations;

namespace ByJoshgunFinalRestaurantProject.Models
{
    public class Food
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public string Ingredient { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz.")]
        public int Price { get; set; }
        public Menu Menu { get; set; }
        public int MenuId { get; set; }
        public bool IsDeactive { get; set; }
    }
}
