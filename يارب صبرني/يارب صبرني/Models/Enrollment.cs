using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace يارب_صبرني.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        [Required]
        [ForeignKey("SubjectId")]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal Grade { get; set; }

    }
}
