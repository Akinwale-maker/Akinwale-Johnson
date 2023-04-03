using APIProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        List<Student> students = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "Funke",
                Gender = "M",
                Age = 18
            },
             new Student
            {
                Id = 2,
                Name = "James",
                Gender = "M",
                Age = 29
            },
              new Student
            {
                Id = 3,
                Name = "Deborah",
                Gender = "F",
                Age = 18
            },
               new Student
            {
                Id = 4,
                Name = "Kola",
                Gender = "M",
                Age = 23
            },
                new Student
            {
                Id = 5,
                Name = "Bola",
                Gender = "M",
                Age = 20
            },
        };

        [HttpGet("List")]
        public List<Student> GetStudents()
        {
            List<Student> stus = students.ToList();
            return stus;
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddStudent([FromBody] Student obj)
        {
            var checkId = students.Where(q => q.Id == obj.Id).FirstOrDefault();
            if (checkId != null)
            {
                return BadRequest(obj);
            }
            Student student = new Student()
            {
                Id = obj.Id,
                Name = obj.Name,
                Gender = obj.Gender,
                Age = obj.Age
            };
            students.Add(student);
            return Ok(students);
        }

        [HttpGet]
        [Route("{Id}/najjjjffffffjme/{Name}")]
        public IActionResult GetById(int Id, string Name)
        {
            var student = students.Where(q => q.Id == Id && q.Name == Name).FirstOrDefault();
            if (student == null)
            {
                return StatusCode(404, "Not Found");
            }

            return Ok(student);
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteById(int Id) 
        { 
            var student = students.Where(q => q.Id == Id).FirstOrDefault();
            if (student == null)
            {
                return StatusCode(404, "Not Found");
            }
            students.Remove(student);

            return Ok(students);

        }

        [HttpPut]
        [Route("/update/{Id}")]
        public IActionResult Update(int Id,[FromBody] Student obj)
        {
            if(Id == obj.Id)
            {
                var student = students.Where(q => q.Id == Id).FirstOrDefault();
                if (student == null)
                {
                    return StatusCode(404, "Not Found");
                }

                student.Age = obj.Age;
                student.Name = obj.Name;
                student.Gender = obj.Gender;
                return Ok(students);
            }
          
            return BadRequest("Invalid");

        }



    }
}
