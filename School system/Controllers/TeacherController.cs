using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Schoolsystem.Domain;
using Schoolsystem.Persistence;

namespace School_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly School_systemDbContext _context;

        public TeacherController(School_systemDbContext context)
        {
            _context = context;
        }

        // Create Teacher
        [HttpPost]
        public async Task<ActionResult<Teacher>> CreateTeacher([FromBody] Teacher teacher)
        {
            if (teacher == null)
                return BadRequest("Invalid teacher data");

            // Validation for email
            var emailExist = await _context.Teachers
                .FirstOrDefaultAsync(s => s.Email.ToLower() == teacher.Email.ToLower());

            if (emailExist != null)
                return BadRequest("Email already exists");

            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();

            // ✅ return 201 with location
            return CreatedAtAction(nameof(GetTeacherById), new { id = teacher.Id }, teacher);
        }

        // Get teacher By Id
        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetTeacherById(int id)
        {
            var teacherExist = await _context.Teachers.FindAsync(id);

            if (teacherExist == null)
                return NotFound();

            // ✅ return actual teacher data
            return Ok(teacherExist);
        }

        // Get all teachers
        [HttpGet]
        public async Task<ActionResult<List<Teacher>>> GetAllTeacher()
        {
            return await _context.Teachers.ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTeacher(int id, [FromBody] Teacher teacher)
        {
            var teacherExist = await _context.Teachers.FindAsync(id);

            if (teacherExist == null)
            {
                return NotFound();
            }

            // Update fields
            teacherExist.TeacherName = teacher.TeacherName;
            teacherExist.Email = teacher.Email;
            teacherExist.PhoneNumber = teacher.PhoneNumber;
            teacherExist.Gender = teacher.Gender;
            teacherExist.Qualification = teacher.Qualification;
            teacherExist.DateOfHire = teacher.DateOfHire;
            teacherExist.DateOfBirth = teacher.DateOfBirth;

            await _context.SaveChangesAsync();

            return NoContent(); // ✅ must always return something
        }


        // Delete teacher
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTeacher(int id)
        {
            var teacherExist = await _context.Teachers.FindAsync(id);

            if (teacherExist == null)
                return NotFound(new { message = $"Teacher with ID {id} not found." });

            _context.Teachers.Remove(teacherExist);
            await _context.SaveChangesAsync();

            return NoContent(); 
        }
    }
}
