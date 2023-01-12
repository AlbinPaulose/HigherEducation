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

        [HttpGet("viewallcolleges")]
        public async Task<List<CollegeNew>> ViewAllColleges()
        {
            return objDataContextClass.tblcollegenew.ToList();
        }

        //delete college
        [HttpDelete("deletecollege/{id}")]
        public async Task<ActionResult<CollegeNew>> DeleteCollege(int id)
        {
            var college = await objDataContextClass.tblcollegenew.FindAsync(id);
            if (college == null)
            {
                return NotFound();
            }
            objDataContextClass.tblcollegenew.Remove(college);
            await objDataContextClass.SaveChangesAsync();
            return college;
        }

        //get college details based on id
        [HttpGet("getcollegebyid/{id}")]
        public IActionResult GetCollegeData(int id)
        {
            return Ok(objDataContextClass.tblcollegenew.Find(id));
        }

        //update college
        [HttpPost("updatecollege")]
        public async Task<IActionResult> UpdateCollege(CollegeNew college)
        {
            objDataContextClass.tblcollegenew.Update(college);
            await objDataContextClass.SaveChangesAsync();
            return Ok(college);
        }

        //giving options to sort

        [HttpGet("filtercollegesTypesOn/{type}")]
        public IActionResult GetFilterTypes(string type)
        {
            var collist = objDataContextClass.tblcollegenew.Select(x => type).Distinct().ToList();
            //var collist = new List<CollegeNew>();
            if (type == "CourseName") {

                collist = objDataContextClass.tblcollegenew.Select(x => x.CourseName).Distinct().ToList();
                
            }
            else if(type == "University") {
                collist = objDataContextClass.tblcollegenew.Select(x => x.University).Distinct().ToList();

            }
            else if(type == "District") {
                collist = objDataContextClass.tblcollegenew.Select(x => x.District).Distinct().ToList();

            }
            return Ok(collist);

        }


        [HttpGet("filterCollegesOn/{sortBy}")]
        public async Task<IActionResult> FilterCollegesOn(string sortBy)
        {
            var colleges = objDataContextClass.tblcollegenew.Where(c => c.CourseName.Equals(sortBy) || c.University.Equals(sortBy) || c.District.Equals(sortBy)).ToList();
            return Ok(colleges);
        }

        
    }
}
