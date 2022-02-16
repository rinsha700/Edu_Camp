using System.ComponentModel.DataAnnotations;

namespace Edu_Camp.Models
{
    public class Student
    {
        [Key]
        public int RegNum { get; set; }
        public string Name { get; set; }

        public string Department { get; set; }
        public string Division { get; set; }
    }
}

