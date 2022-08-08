using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.Models;
using TodoAPI.DTOs;
using TodoDLA.Models;

namespace TodoAPI.Services
{
    public interface ITokenService
    {
        Task<ProcessResult<JwtTokenModel>> Authenticate(AuthenticateUserDTO userDTO);
        void VerifyUser(User user, string password);
    }
}