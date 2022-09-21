using System.ComponentModel.DataAnnotations;

namespace DrinkFest.ViewModel
{
    public class RegisterViewModel
    {
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Password do not match")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
