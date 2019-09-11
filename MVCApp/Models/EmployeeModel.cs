using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name ="Employee ID")]
        [Range(100000, 999999, ErrorMessage = "You need to enter a valid employee ID")]
        public int EmployeeID { get; set; }

        [Display(Name = "Employee First Name")]
        [Required(ErrorMessage ="Please enter a first name")]
        public string FirstName { get; set; }

        [Display(Name = "Employee Last Name")]
        [Required(ErrorMessage = "Please enter a last name")]
        public string LastName { get; set; }

        [Display(Name = "Employee e-mail address")]
        [Required(ErrorMessage = "Please enter an e-mail address")]
        public string EmailAddress { get; set; }

        [Display(Name = "confirm e-mail")]
        [Compare("EmailAddress", ErrorMessage = "Email adresses do not match")]
        [DataType(DataType.EmailAddress)]
        public string ConfirmEmail { get; set; }

        [Display(Name ="Password")]
        [Required(ErrorMessage ="You must enter a password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 7, ErrorMessage ="The Password must be atleast 7 characters long")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="The passwords do not match")]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "You must enter a matching password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}