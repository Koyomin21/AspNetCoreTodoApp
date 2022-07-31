using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using TodoDLA.Models;
using TodoDLA.Enums;

namespace TodoDLA;
public class ApplicationDbContext : DbContext
{
    // public ApplicationDbContext(){}
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=TodosDb;User ID=postgres;Password=anuar123;");
    // }
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Todo> Todos { get; set; }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
        .HasMany(u => u.Todos)
        .WithOne(t => t.User);

        modelBuilder.Entity<Role>()
        .HasMany(r => r.Users)
        .WithOne(u => u.Role);

        modelBuilder.Entity<Role>()
        .Property(r => r.Name)
        .HasConversion<string>();

        // seeding roles
        List<Role> roles = new List<Role>();
        foreach(int i in Enum.GetValues(typeof(RoleType)))
        {
            roles.Add(new Role() { Id = i,  Name = (RoleType)i });
        }
        modelBuilder.Entity<Role>()
        .HasData(roles);
        
        
    }
}
