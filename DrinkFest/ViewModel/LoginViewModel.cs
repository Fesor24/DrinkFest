using System.ComponentModel.DataAnnotations;

namespace DrinkFest.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
