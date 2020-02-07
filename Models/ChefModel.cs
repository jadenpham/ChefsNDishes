using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get; set;}

        [Required(ErrorMessage = "First Name Required")]
        [Display(Name = "Chef's First Name")]
        public string FirstName {get; set;}

        [Required(ErrorMessage = "Last Name Required")]
        [Display(Name = "Chef's Last Name")]
        public string LastName {get; set;}

        [Required(ErrorMessage= "DOB must be a past date")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [AgeCheck]
        public DateTime DOB {get; set;}

        public List<Dish> OwnDishes {get; set;}
    }

    public class AgeCheck : ValidationAttribute
    {
        protected override ValidationResult IsValid(object date, ValidationContext validationContext)
        {
            DateTime DOB = Convert.ToDateTime(date);
            DateTime today = DateTime.Now;
            var age = today.Year - DOB.Year;
            if(DOB.Date > today.AddYears(-age)) age--;
            if(age < 18)
            {
                return new ValidationResult("Chef must be 18 years or older");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }

    public class AgeCalculator
    {
        public static int CalcAge(DateTime DOB)
        {
            int age = 0;
            age = DateTime.Now.Year - DOB.Year;
            if(DateTime.Now.DayOfYear < DOB.DayOfYear)
                age--;
            return age;
        }
    }
}