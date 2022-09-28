using Microsoft.EntityFrameworkCore;

namespace SoalNo4.Entities
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
                    Id = Guid.NewGuid(),
                    Name = "Chandra",
                    Email = "chandra@gmail.com",
                    Phone = 12345678,
                    Salary = 2000000
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Dodi",
                    Email = "Dodi@gmail.com",
                    Phone = 12245678,
                    Salary = 4000000
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Agus",
                    Email = "agus@gmail.com",
                    Phone = 12366678,
                    Salary = 3000000
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Taufik",
                    Email = "taufik@gmail.com",
                    Phone = 12345888,
                    Salary = 6000000
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Retno",
                    Email = "retno@gmail.com",
                    Phone = 123433333,
                    Salary = 5000000
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Tyas",
                    Email = "tyas@gmail.com",
                    Phone = 15555678,
                    Salary = 2400000
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Ryan",
                    Email = "ryan@gmail.com",
                    Phone = 1111345678,
                    Salary = 7100000
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Rino",
                    Email = "rino@gmail.com",
                    Phone = 14444678,
                    Salary = 3200000
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Aji",
                    Email = "aji@gmail.com",
                    Phone = 66665678,
                    Salary = 9000000
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Ani",
                    Email = "ani@gmail.com",
                    Phone = 18885678,
                    Salary = 3500000
                }
            );
        }
    }
}
