using System;
using System.ComponentModel.DataAnnotations;

namespace Chef_Dishes.Models {
    public class CaloriesAttribute : ValidationAttribute {
        protected override ValidationResult IsValid (object value, ValidationContext validationContext) {
            string Calories = (string) value;
            if (Calories == "0") {
                return new ValidationResult ("Calories Must be Greater than 0!");
            } else
                return ValidationResult.Success;
        }
    }
}
