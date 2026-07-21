using StudentManagementSystem.DTOs;
using StudentManagementSystem.Interfaces;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<StudentDto>> GetAllStudentsAsync()
        {
            var students = await _repository.GetAllStudentsAsync();

            return students.Select(s => new StudentDto
            {
                Id = s.Id,
                Name = s.Name,
                Email = s.Email,
                Age = s.Age,
                Course = s.Course
            });
        }

        public async Task<StudentDto?> GetStudentByIdAsync(int id)
        {
            var student = await _repository.GetStudentByIdAsync(id);

            if (student == null)
                return null;

            return new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Email = student.Email,
                Age = student.Age,
                Course = student.Course
            };
        }

        public async Task<StudentDto> AddStudentAsync(CreateStudentDto dto)
        {
            var student = new Student
            {
                Name = dto.Name,
                Email = dto.Email,
                Age = dto.Age,
                Course = dto.Course
            };

            var result = await _repository.AddStudentAsync(student);

            return new StudentDto
            {
                Id = result.Id,
                Name = result.Name,
                Email = result.Email,
                Age = result.Age,
                Course = result.Course
            };
        }

        public async Task<StudentDto?> UpdateStudentAsync(int id, UpdateStudentDto dto)
        {
            var student = await _repository.GetStudentByIdAsync(id);

            if (student == null)
                return null;

            student.Name = dto.Name;
            student.Email = dto.Email;
            student.Age = dto.Age;
            student.Course = dto.Course;

            await _repository.UpdateStudentAsync(student);

            return new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Email = student.Email,
                Age = student.Age,
                Course = student.Course
            };
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            return await _repository.DeleteStudentAsync(id);
        }
    }
}