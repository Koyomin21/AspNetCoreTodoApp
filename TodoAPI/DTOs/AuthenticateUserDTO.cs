using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TodoAPI.DTOs
{
    public class AuthenticateUserDTO
    {
        [DataType(DataType.EmailAddress)]
        [Required]        
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}