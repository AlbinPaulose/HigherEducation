using System.ComponentModel.DataAnnotations;
namespace BackendEdukit.Models
{
    public class FututeCourse
    {
        [Key]
        public int futureCourseid { get; set; }
        public int Courseid { get; set; }
        public string? futureCoursename { get; set; }
        public string? futureCoursetype { get; set; }
    }
}
