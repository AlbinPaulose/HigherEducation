using BackendEdukit.Data;
using BackendEdukit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendEdukit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        public DataContextClass objDataContextClass { get; set; }
        public CourseController(DataContextClass courseContext)
        {
            this.objDataContextClass = courseContext;
        }

        //insert course

        [HttpPost("insertcourse")]
        public async Task<ActionResult> InsertCourse(Course course)
        {
            objDataContextClass.tblcourse.Add(course);
            await objDataContextClass.SaveChangesAsync();
            return Ok(course);
        }

        //viewing course

        [HttpGet("viewcourse")]
        public async Task<List<Course>> ViewCourse()
        {
            return objDataContextClass.tblcourse.ToList();
        }

        [HttpPost("insertfuturecourse")]

        public async Task<ActionResult> InsertfutureCourse(FututeCourse fcourse)
        {
            objDataContextClass.tblfuturecourse.Add(fcourse);
            await objDataContextClass.SaveChangesAsync();
            return Ok(fcourse);
        }

        [HttpGet("getfuturecourse")]
        public async Task<List<FututeCourse>> ViewfutureCourse()
        {
            return objDataContextClass.tblfuturecourse.ToList();
        }

        [HttpGet("sortcourse/{id}")]
        public async Task<IActionResult> SortCourses(int id)
        {
            
            var courses = objDataContextClass.tblfuturecourse.Where(c=> c.Courseid.Equals(id)).ToList();
            return Ok(courses);
        }
    }
}
