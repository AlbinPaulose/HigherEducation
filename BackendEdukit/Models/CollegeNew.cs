using System.ComponentModel.DataAnnotations;

namespace BackendEdukit.Models
{
    public class CollegeNew
    {
        [Key]
        public int CollegeId { get; set; }

        public string? CourseName { get; set; }

        public string? CollegeName { get; set; }

        public int SeatsAvailable { get; set; }

        public string? University { get; set; }

        public string? District { get; set; }

        public string? Address { get; set; }
    }
}
