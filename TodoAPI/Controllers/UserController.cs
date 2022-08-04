using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TodoAPI.DTOs;
using TodoAPI.Services;

namespace TodoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IUserService _userService;
        public UserController(ITokenService tokenService, IUserService userService)
        {
            _tokenService = tokenService;
            _userService = userService;
        }

        [HttpPost]
        [Route("authenticate/")]
        [AllowAnonymous]
        public async Task<IActionResult> AuthenticateUser([FromBody]AuthenticateUserDTO userDTO)
        {
            var result = await _tokenService.Authenticate(userDTO);
            if(!result.Succeeded)
                return BadRequest(result.Errors);
            
            return Ok(result.Value);

        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _userService.GetAllUsers();
            if(!result.Succeeded)
                return BadRequest(result.Errors);
            
            return Ok(result.Value);
            
        }

    }
}