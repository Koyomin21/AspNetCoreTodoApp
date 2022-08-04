using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.Models;
using TodoAPI.DTOs;

namespace TodoAPI.Services
{
    public interface IUserService
    {
        Task<ProcessResult<List<GetUserDto>>>GetAllUsers();   
    }
}