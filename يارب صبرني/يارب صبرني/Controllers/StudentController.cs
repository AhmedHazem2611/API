using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using يارب_صبرني.Models;

namespace يارب_صبرني.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController()
        {
            _context = new AppDbContext();
        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _context.Students.ToList();
            return Ok(students);
        }
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _context.Students.SingleOrDefault(x => x.Id == id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} was not found.");
            }
            return Ok(student);
        }

    }
}
