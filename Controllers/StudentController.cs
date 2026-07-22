using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.DTOs;
using StudentManagementSystem.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace StudentManagementSystem.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            return Ok(await _service.GetAllStudentsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var student = await _service.GetStudentByIdAsync(id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(CreateStudentDto dto)
        {
            var student = await _service.AddStudentAsync(dto);

            return CreatedAtAction(nameof(GetStudent),
                new { id = student.Id }, student);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, UpdateStudentDto dto)
        {
            var student = await _service.UpdateStudentAsync(id, dto);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var deleted = await _service.DeleteStudentAsync(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}