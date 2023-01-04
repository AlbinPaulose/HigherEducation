using System.ComponentModel.DataAnnotations;

namespace BackendEdukit.Models
{
    public class College
    {
        [Key]
        public int ColgId { get; set; }

        public int futureCourseid { get; set; }
        public int Courseid { get; set; }

        public string? CollegeName { get; set; }

        public string? University { get; set; }

        public string? District { get; set; }




    }
}
