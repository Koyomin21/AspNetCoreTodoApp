using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoDLA;
using Microsoft.EntityFrameworkCore;


namespace TodoAPI.Configurations
{
    public static class DbConfigurationExtension
    {
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
    }
}