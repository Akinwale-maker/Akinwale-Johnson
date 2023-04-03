
using APIProject.DTO;
using APIProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewStudentController : ControllerBase
    {
        private readonly IStudentServices _student;

        public NewStudentController( IStudentServices student)
        {
            _student = student;
        }


        [HttpPost]
        [Route("AddStudent")]

        public async Task<IActionResult> AddStudent([FromBody] StudentDto studentDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _student.AddStudent(studentDto);
            return Ok(result);
            //return Ok(await _student.AddStudent(studentDto));
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudent()
        {
            var result = await _student.GetStudents();
            return Ok(result);
        }
    }
}
