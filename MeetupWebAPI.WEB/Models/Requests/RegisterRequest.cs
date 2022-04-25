using System.ComponentModel.DataAnnotations;

namespace MeetupWebAPI.WEB.Models.Requests
{
    public class RegisterRequest
    {
        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "Firstname must be filled!")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Lastname must be filled!")]
        public string LastName { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Username must be filled!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Incorrect username input format!")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password must be filled!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "ConfirmPassword")]
        [Required(ErrorMessage = "Password must be confirmed!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords don't match!")]
        public string ConfirmPassword { get; set; }
    }
}
