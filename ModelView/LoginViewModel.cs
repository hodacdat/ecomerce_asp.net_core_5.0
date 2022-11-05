using System.ComponentModel.DataAnnotations;

namespace PE.ModelView
{
    public class LoginViewModel
    {
        [Key]
        [MaxLength(100)]
        [Required(ErrorMessage ="Please enter Email")]
        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        public string  Email { get; set; }      
        
        [MinLength(5,ErrorMessage ="Password need to be more than 5 characters")]
        [Required(ErrorMessage ="Please enter password")]
        [Display(Name ="Password")]
        public string Password { get; set; }
    }
}
