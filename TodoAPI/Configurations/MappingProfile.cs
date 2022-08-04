using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TodoAPI.DTOs;
using TodoDLA.Models;

namespace TodoAPI.Configurations
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Todo, GetTodoDto>();
            CreateMap<CreateTodoDto, Todo>();
            CreateMap<GetUserDto, User>();
            CreateMap<User, GetUserDto>()
            .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.Name.ToString()));
            
        }
    }
}