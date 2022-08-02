using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoDLA.Models;
using TodoDLA.Enums;

namespace TodoDLA.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            // seeding roles
            List<Role> roles = new List<Role>();
            foreach(int i in Enum.GetValues(typeof(RoleType)))
            {
                roles.Add(new Role() { Id = i,  Name = (RoleType)i });
            }
            modelBuilder.Entity<Role>()
            .HasData(roles);
        }

        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            
            List<User> users = new List<User>()
            {
                new User() { Id = 1, Email = "anuar@mail.ru", Password =  BCrypt.Net.BCrypt.HashPassword("anuar123"), RoleId = (int)RoleType.Admin },
                new User() { Id = 2, Email = "elvira@mail.ru", Password =  BCrypt.Net.BCrypt.HashPassword("elvira123"), RoleId = (int)RoleType.User },
                new User() { Id = 3, Email = "aldik@mail.ru", Password =  BCrypt.Net.BCrypt.HashPassword("aldik123"), RoleId = (int)RoleType.User }

            };

            modelBuilder.Entity<User>().HasData(users);
        }

        
    }
}