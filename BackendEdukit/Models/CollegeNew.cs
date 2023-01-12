using System.ComponentModel.DataAnnotations;

namespace BackendEdukit.Models
{
    public class CollegeNew
    {
        [Key]
        public int CollegeId { get; set; }

        public string? CourseName { get; set; }

        [Required(ErrorMessage = "Please enter college name")]
        public string? CollegeName { get; set; }

        [Required(ErrorMessage = "Please enter no of seats")]

        public int SeatsAvailable { get; set; }

        public string? University { get; set; }

        public string? District { get; set; }

        public string? Address { get; set; }
    }
}
