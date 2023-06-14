using System.ComponentModel.DataAnnotations;

namespace PostgreSqlAsp.Models
{
    public class LoginUser
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? ReturnUrl { get; set; }
    }
}