using APIProject.DTO;
using APIProject.Model;

namespace APIProject.Services
{
    public interface IStudentServices
    {
        Task<StudentDto> AddStudent(StudentDto studentDto);

        Task<Student> UpdateStudent();

        Task<List<Student>> GetStudents();
    }
}
