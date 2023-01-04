using System.ComponentModel.DataAnnotations;

namespace BackendEdukit.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public string CourseType { get; set; }

        
    }
}
