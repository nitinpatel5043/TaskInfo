using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInfo.Core.Domain.Entities
{
    public class LoginUser
    {
        [Required(ErrorMessage = "UserName is required.")]
        public required string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public required string Password { get; set; }
    }
}
