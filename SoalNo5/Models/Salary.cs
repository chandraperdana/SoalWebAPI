using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoalNo5.Models
{
    public class Salary
    {
        [Key]
        public int SalaryId { get; set; }
        public int EmpId { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalSalary { get; set; }
    }
}
