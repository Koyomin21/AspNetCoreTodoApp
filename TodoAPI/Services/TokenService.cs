using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoDLA;
using TodoAPI.Models;
using TodoAPI.DTOs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Exceptions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using TodoDLA.Models;

namespace TodoAPI.Services
{
    public class TokenService : BaseService, ITokenService
    {
        private readonly IUserService _userService;
        public TokenService(ApplicationDbContext context, IMapper mapper, IConfiguration configuration, IUserService userService)
         : base(context, mapper, configuration)
        {
            _userService = userService;
        }

        public async Task <ProcessResult<JwtTokenModel>> Authenticate(AuthenticateUserDTO userDTO)
        {
            Func<Task<JwtTokenModel>> action = async ()=> 
            {
                var user = await _userService.GetUserByEmailAsync(userDTO.Email);
                VerifyUser(user, userDTO.Password);
                
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role,  user.Role.Name.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(Convert.ToInt16(_configuration["JWT:ExpiresInMinutes"])),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)

                };
                var token = tokenHandler.CreateToken(tokenDescriptor);

                return new JwtTokenModel { Value = tokenHandler.WriteToken(token) };
            };

            return await Process.RunAsync(action);
            
        }

        public void VerifyUser(User user, string password)
        {
            if(user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password)) 
                throw new BadCredentialsException("Wrong username or password!");
            
        }
    }
}