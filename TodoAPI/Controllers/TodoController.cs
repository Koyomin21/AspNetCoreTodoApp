using System;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.Services;
using TodoAPI.DTOs;

namespace TodoAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly ITodoService _todoService;
    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetTodos()
    {
        var result = await _todoService.GetAllTodosAsync();
        if(!result.Succeeded)
            return BadRequest(result.Errors);
        
        return Ok(result.Value);
    }   

    [HttpPost]
    //[Route("/newTodo")]
    public async Task<IActionResult> CreateTodo([FromBody] CreateTodoDto newTodo)
    {
        var result = await _todoService.CreateTodoAsync(newTodo);
        if(!result.Succeeded)
            return BadRequest(result.Errors);
        
        return Ok();
    }
}
