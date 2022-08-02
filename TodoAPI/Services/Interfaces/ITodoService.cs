using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.Models;
using TodoAPI.DTOs;


namespace TodoAPI.Services;

public interface ITodoService
{
    Task<ProcessResult<List<GetTodoDto>>> GetAllTodosAsync();
    Task<ProcessResult> CreateTodoAsync(CreateTodoDto newTodo);
}