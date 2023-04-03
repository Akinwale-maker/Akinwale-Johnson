using System.ComponentModel.DataAnnotations;

namespace APIProject.DTO
{
    public class StudentDto
    {
        [Required]
        public string Name { get; set; }

        [Required]

        public string Gender { get; set; }

        [Required]

        public int Age { get; set; }
    }
}
