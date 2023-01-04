using BackendEdukit.Data;
using BackendEdukit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendEdukit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public DataContextClass objDataContextClass { get; set; }
        public UsersController(DataContextClass courseContext)
        {
            this.objDataContextClass = courseContext;
        }
        [HttpGet("getcoursename")]
        public async Task<List<Course>> ViewCourse()
        {
            return objDataContextClass.tblcourse.ToList();
        }

        [HttpGet("displayfuturecourse/{id}")]
        public async Task<IActionResult> DisplayFutureCourse(int id)
        {
            var fcourses = objDataContextClass.tblfuturecourse.Where(c => c.Courseid.Equals(id)).ToList();
            return Ok(fcourses);
        }

        [HttpGet("viewcolleges/{course}")]
        public async Task<IActionResult> ViewColleges(string course)
        {
            var colleges = objDataContextClass.tblcollegenew.Where(colg => colg.CourseName.Equals(course)).ToList();
            return Ok(colleges);
        }
    }
}
