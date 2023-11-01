using System.ComponentModel.DataAnnotations;

namespace Url_Shortener.Models
{
    public class AuthenticationRequestBody
    {

        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
