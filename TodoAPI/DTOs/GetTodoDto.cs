using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoDLA.Models;


namespace TodoAPI.DTOs
{
    public class GetTodoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Boolean isCompleted { get; set; }
        public int UserId { get; set;}
    }
}