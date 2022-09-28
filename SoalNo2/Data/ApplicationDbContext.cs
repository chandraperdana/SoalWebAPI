using Microsoft.EntityFrameworkCore;
using SoalNo2.Models;

namespace SoalNo2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Chandra",
                    Email = "chandra@gmail.com",
                    Phone = 12345678,
                    Salary = 2000000
                },
                new Employee
                {
                    Id = 2,
                    Name = "Dodi",
                    Email = "Dodi@gmail.com",
                    Phone = 12245678,
                    Salary = 4000000
                },
                new Employee
                {
                    Id = 3,
                    Name = "Agus",
                    Email = "agus@gmail.com",
                    Phone = 12366678,
                    Salary = 3000000
                },
                new Employee
                {
                    Id = 4,
                    Name = "Taufik",
                    Email = "taufik@gmail.com",
                    Phone = 12345888,
                    Salary = 6000000
                },
                new Employee
                {
                    Id = 5,
                    Name = "Retno",
                    Email = "retno@gmail.com",
                    Phone = 123433333,
                    Salary = 5000000
                },
                new Employee
                {
                    Id = 6,
                    Name = "Tyas",
                    Email = "tyas@gmail.com",
                    Phone = 15555678,
                    Salary = 2400000
                },
                new Employee
                {
                    Id = 7,
                    Name = "Ryan",
                    Email = "ryan@gmail.com",
                    Phone = 1111345678,
                    Salary = 7100000
                },
                new Employee
                {
                    Id = 8,
                    Name = "Rino",
                    Email = "rino@gmail.com",
                    Phone = 14444678,
                    Salary = 3200000
                },
                new Employee
                {
                    Id = 9,
                    Name = "Aji",
                    Email = "aji@gmail.com",
                    Phone = 66665678,
                    Salary = 9000000
                },
                new Employee
                {
                    Id = 10,
                    Name = "Ani",
                    Email = "ani@gmail.com",
                    Phone = 18885678,
                    Salary = 3500000
                }
            );
        }
    }
}
