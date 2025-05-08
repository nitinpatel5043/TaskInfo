using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInfo.Core.Domain.Entities
{
    public class User
    {
        [Required(ErrorMessage = "{0} is required")]
        public Guid UserId { get; set; }

        [Key]
        [Required(ErrorMessage = "{0} is required")]
        public required string UserName { get; set; }
    }
}
