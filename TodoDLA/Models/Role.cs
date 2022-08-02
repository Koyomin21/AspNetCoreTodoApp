using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoDLA.Enums;


namespace TodoDLA.Models
{
    public class Role
    {
        public int Id { get; set; }
        public RoleType Name { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}