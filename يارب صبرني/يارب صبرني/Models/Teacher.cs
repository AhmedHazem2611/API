using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace يارب_صبرني.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(150)]
        public string EmailAddress { get; set; }
        [MaxLength(20)]
        [Phone]
        public string? PhoneNumber { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();

    }
}
