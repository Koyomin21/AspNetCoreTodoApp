using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoDLA;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Services;


namespace TodoAPI.Configurations
{
    public static class ServicesExtensions
    {
        private static readonly IConfiguration _configuration; 

        
        public static void ConfigureDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString, optionsBuilder => 
                {
                    optionsBuilder.MigrationsAssembly("TodoDLA");
                });
            });
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ITodoService, TodoService>();
        }

        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Program));

        }
    }
}