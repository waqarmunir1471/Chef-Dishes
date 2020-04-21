using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chef_Dishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId{get;set;}
        [Required]
        [Display(Name="First Name : ")]
        public string FirstName {get;set;}
        [Required]
        [Display(Name="Last Name : ")]
        public string LastName{get;set;}
        
        [Required]
        [DOB]
        [DataType(DataType.Date)]
        public DateTime DOB {get;set;}
        public int DishId {get;set;}
        public List<Dish> DishesByChef {get;set;}

    }
}