using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAPI.DTOs
{
    public class GetUserDto
    {
        public string Email { get; set; }
        public string Role { get; set; }
    }
}