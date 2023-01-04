using BackendEdukit.Data;
using BackendEdukit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendEdukit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        public DataContextClass objDataContextClass { get; set; }
        public CollegeController(DataContextClass courseContext)
        {
            this.objDataContextClass = courseContext;
        }
        [HttpPost("insertcollege")]
        public async Task<ActionResult> InsertCollege(College college)
        {
            objDataContextClass.tblcollege.Add(college);
            await objDataContextClass.SaveChangesAsync();
            return Ok(college);
        }

        [HttpPost("addcolleges")]
        public async Task<ActionResult> AddColleges(CollegeNew colgnew)
        {
            objDataContextClass.tblcollegenew.Add(colgnew);
            await objDataContextClass.SaveChangesAsync();
            return Ok(colgnew);
        }
    }
}
