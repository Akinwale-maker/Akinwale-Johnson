using APIProject.Data;
using APIProject.DTO;
using APIProject.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace APIProject.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly AppDbContext _ctx;
        public StudentServices(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<StudentDto> AddStudent(StudentDto studentDto)
        {
            Student student = new Student()
            {
                Name= studentDto.Name,
                Age= studentDto.Age,
                Gender= studentDto.Gender,
            };
            
            _ctx.MyStudent.Add(student);
            await _ctx.SaveChangesAsync();
            return studentDto;

        }

        public async Task<List<Student>> GetStudents()
        {
            var students = await _ctx.MyStudent.ToListAsync();

            return students;
        }

        public Task<Student> UpdateStudent()
        {
            throw new NotImplementedException();
        }
    }
}
