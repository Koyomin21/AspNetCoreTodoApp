using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.DTOs;
using TodoAPI.Models;
using TodoDLA;
using TodoDLA.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace TodoAPI.Services
{
    public class TodoService : BaseService, ITodoService
    {
        public TodoService(ApplicationDbContext context, IMapper mapper, IConfiguration configuration)
         : base(context, mapper, configuration)
        {
            
        }

        public async Task<ProcessResult<List<GetTodoDto>>> GetAllTodosAsync()
        {
            Func<Task<List<GetTodoDto>>> action = async ()=> 
            {
                var todos = _context.Todos.AsNoTracking().Select(t => _mapper.Map<GetTodoDto>(t)).ToListAsync();
                return await todos;
            };

            return await Process.RunAsync(action);
        }
        public async Task<ProcessResult> CreateTodoAsync(CreateTodoDto newTodo)
        {
            Func<Task> action = async ()=> 
            {
                var todo = _mapper.Map<Todo>(newTodo);
                await _context.Todos.AddAsync(todo);    
                await _context.SaveChangesAsync();
            };


            return await Process.RunAsync(action);
        }
    }
}