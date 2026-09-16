using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace يارب_صبرني.Models
{
    public class Student
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
        [MaxLength(150)]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [MaxLength(20)]
        [Phone]
        public int? PhoneNumber { get; set; }
        [Required]
        public DateTime DateOfBirth {  get; set; }
        [ForeignKey("ClassRoom")]
        public int ClassRoomId { get; set; }
        public Classroom Classroom { get; set; }
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
