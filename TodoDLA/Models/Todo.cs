using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoDLA.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Boolean isCompleted { get; set; } = false;
        public User User { get; set; }
    }
}