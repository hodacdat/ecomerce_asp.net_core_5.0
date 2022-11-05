using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PE.ModelView
{
    public class RegisterVM
    {
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Please enter full name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter Email")]
        [MaxLength(150)]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "ValidateEmail", controller: "Accounts")]
        public string Email { get; set; }

        [MaxLength(11)]
        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [Remote(action: "ValidatePhone", controller: "Accounts")]
        public string Phone { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter password")]
        [MinLength(5, ErrorMessage = "The password must be at least 5 characters")]
        public string Password { get; set; }

        [MinLength(5, ErrorMessage = "The password must be at least 5 characters")]
        [Display(Name = "Re-enter password")]
        [Compare("Password", ErrorMessage = "please type same password")]
        public string ConfirmPassword { get; set; }
    }
}
