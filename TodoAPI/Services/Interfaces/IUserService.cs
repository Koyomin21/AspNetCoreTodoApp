using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.Models;
using TodoAPI.DTOs;
using TodoDLA.Models;

namespace TodoAPI.Services
{
    public interface IUserService
    {
        Task<ProcessResult<List<GetUserDto>>>GetAllUsers();
        Task<User> GetUserByEmailAsync(string email);
    }
}