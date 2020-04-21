using System;
using System.ComponentModel.DataAnnotations;

namespace Chef_Dishes.Models {
    public class DOBAttribute : ValidationAttribute {
        protected override ValidationResult IsValid (object value, ValidationContext validationContext) {
            DateTime DOB = (DateTime) value;
            DateTime today = DateTime.Today;
            int age = today.Year - DOB.Year;
            if (DOB > DateTime.Now ) {
                return new ValidationResult ("Please Enter a Valid Date and Time!");
            } else if (age < 18){
                return new ValidationResult ("You must be 18!");
            }
            else if (DOB > DateTime.Now ) {
                return new ValidationResult ("DOB Must be In Past!");
            }
            else {
                    return ValidationResult.Success;
                }
        }

    }
}
