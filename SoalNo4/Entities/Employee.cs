using SoalNo4.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SoalNo4.Entities
{
    public class Employee : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public long Salary { get; set; }
    }
}
