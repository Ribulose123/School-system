using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Schoolsystem.Domain;
using Schoolsystem.Persistence;

namespace School_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly School_systemDbContext _context;

        public StudentController(School_systemDbContext context)
        {
            _context = context;
        }

        // ✅ Create Student
        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent([FromBody] Student student)
        {
            if (student == null)
                return BadRequest("Invalid student data");

            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }

        // ✅ Get student by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
                return NotFound();

            return Ok(student);
        }

        // ✅ Get all students
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudent()
        {
            return await _context.Students.ToListAsync();
        }

        // ✅ Update student
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateStudent(int id, [FromBody] Student student)
        {
            var studentExist = await _context.Students.FindAsync(id);

            if (studentExist == null)
            {
                return NotFound();
            }

            studentExist.FullName = student.FullName;
            studentExist.PhoneNumber = student.PhoneNumber;
            studentExist.Address = student.Address;
            studentExist.DateOfBirth = student.DateOfBirth;
            studentExist.DateOfEnrollement = student.DateOfEnrollement;
            studentExist.Gender = student.Gender;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // ✅ Delete Student
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var studentExist = await _context.Students.FindAsync(id);

            if (studentExist == null)
            {
                return NotFound(new { message = $"The student with id {id} was not found" });
            }

            _context.Students.Remove(studentExist);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
