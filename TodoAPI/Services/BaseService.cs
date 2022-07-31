using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoDLA;
using AutoMapper;

namespace TodoAPI.Services
{
    public abstract class BaseService
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;
        public BaseService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

    }
}