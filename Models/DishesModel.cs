using System.ComponentModel.DataAnnotations;
using System;
namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId{get; set;}

        [Required(ErrorMessage = "Dish's name required")]
        [Display(Name = "Dish Name")]
        public string Name {get; set;}

        [Required(ErrorMessage = "Calories must be > 0")]
        [Range(0, 100000)]
        public int Calories{get; set;}

        [Required(ErrorMessage = "Range must be from 1-5")]
        public int Tastiness {get; set;}

        [Required(ErrorMessage = "Description is required")]
        public string Description {get; set;}

        public int ChefId {get; set;}

        public Chef Creator {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;

        public DateTime UpdatedAt {get; set;} = DateTime.Now;

    }
}