using System.ComponentModel.DataAnnotations;
namespace Chef_Dishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId{get;set;}
        [Required(ErrorMessage="Dish Name is Required")]
        [Display(Name="Name of Dish : ")]
        public string DishName {get;set;}
        [Required]
        [Display(Name="# of Calories")]
        public string NoOfCalories {get; set;}
        [Required]
        [Display(Name="Tastines")]
        [Range(0,10)]
        public int? Tastiness {get;set;}
        public int ChefId {get;set;}

        public Chef DishCreator {get;set;}

    }
}