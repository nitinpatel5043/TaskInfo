using System.ComponentModel.DataAnnotations;

namespace TaskInfo.Models
{
    public class RefreshTokenRequest
    {
        [Required]
        public required string RefreshToken { get; set; }
    }

}
