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

        [HttpDelete("deletecourse/{id}")]
        public async Task<ActionResult<Course>> DeleteCourse(int id)
        {
            var course = await objDataContextClass.tblcourse.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            objDataContextClass.tblcourse.Remove(course);
            await objDataContextClass.SaveChangesAsync();
            return course;
        }


        //get course details based on id

        [HttpGet("getcoursebyid/{id}")]
        public IActionResult GetCourseData(int id)
        {
            return Ok(objDataContextClass.tblcourse.Find(id));
        }

        //update course

        [HttpPost("updatecourse")]
        public async Task<IActionResult> UpdateCourse(Course course)
        {
            objDataContextClass.tblcourse.Update(course);
            await objDataContextClass.SaveChangesAsync();
            return Ok(course);
        }

        //delete future course
        [HttpDelete("deletefuturecourse/{id}")]
        public async Task<ActionResult<FututeCourse>> DeleteFutureCourse(int id)
        {
            var future_course = await objDataContextClass.tblfuturecourse.FindAsync(id);
            if (future_course == null)
            {
                return NotFound();
            }
            objDataContextClass.tblfuturecourse.Remove(future_course);
            await objDataContextClass.SaveChangesAsync();
            return future_course;
        }

        //get future course details based on id
        [HttpGet("getfuturecoursebyid/{id}")]
        public IActionResult GetFutureCourseData(int id)
        {
            return Ok(objDataContextClass.tblfuturecourse.Find(id));
        }

        //update future course
        [HttpPost("updatefuturecourse")]
        public async Task<IActionResult> UpdatefutureCourse(FututeCourse fcourse)
        {
            objDataContextClass.tblfuturecourse.Update(fcourse);
            await objDataContextClass.SaveChangesAsync();
            return Ok(fcourse);
        }
    }
}
