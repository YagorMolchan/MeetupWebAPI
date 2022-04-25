using System.ComponentModel.DataAnnotations;

namespace MeetupWebAPI.WEB.Models.Requests
{
    public class AuthenticateRequest
    {
        [Required(ErrorMessage = "Username must be filled!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password must be filled!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
