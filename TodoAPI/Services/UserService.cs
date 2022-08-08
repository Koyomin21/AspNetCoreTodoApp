using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TodoAPI.DTOs;
using TodoAPI.Models;
using TodoDLA;
using Microsoft.EntityFrameworkCore;
using TodoDLA.Models;
using TodoAPI.Exceptions;

namespace TodoAPI.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(ApplicationDbContext context, IMapper mapper, IConfiguration configuration) : base(context, mapper, configuration)
        {
        }

        public async Task<ProcessResult<List<GetUserDto>>> GetAllUsers()
        {
            Func<Task<List<GetUserDto>>> action = async ()=> 
            {
                var users = await _context.Users
                .AsNoTracking()
                .Include(u => u.Role)
                .Select(u => _mapper.Map<GetUserDto>(u))
                .ToListAsync();

                return users;
            };

            return await Process.RunAsync(action);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await _context.Users
                .AsNoTracking()
                .Where(u => u.Email == email)
                .Include(u => u.Role)
                .FirstOrDefaultAsync();
            
            return user;
        }

       
    }
}