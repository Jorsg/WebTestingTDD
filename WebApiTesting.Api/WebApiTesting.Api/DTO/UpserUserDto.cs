using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTesting.Api.DTO
{
    public class UpserUserDto
    {
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
