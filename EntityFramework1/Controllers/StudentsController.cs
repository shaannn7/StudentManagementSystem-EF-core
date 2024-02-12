using EntityFramework1.Entities;
using EntityFramework1.Repostory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudents _istudents;
        public StudentsController(IStudents istudents)
        {
            _istudents = istudents;
        }
        [HttpGet("ALL")]
        public IActionResult Get() 
        {
            return Ok(_istudents.GetStudents());
        }
        [HttpGet("BY ID")]
        public IActionResult GetByID(int id) 
        {
            return Ok(_istudents.GetStudentByID(id));
        }
        [HttpGet("By Filtering Age")]
        public IActionResult FilterByAge(int Age)
        {
            return Ok(_istudents.FilterStudentByAge(Age));
        }
        [HttpGet("Search")]
        public IActionResult Search(string name) 
        {
            return Ok(_istudents.SearchStudentByName(name));
        }
        [HttpPost]
        public IActionResult AddStdnt(Students students)
        {
            _istudents.AddStudent(students);
            return Ok("ADDED SCCESSFULLY");
        }
        [HttpPut("ALL")]
        public IActionResult UpdateAll(Students students)
        {
            _istudents.UpdateStudent(students);
            return Ok("UPDATED SUCCESSFULLY");
        }
        [HttpPut("AGE")]
        public IActionResult Updateid(int id , int age)
        {
            _istudents.UpdateAge(id, age);
            return Ok("AGE CHANGED SUCCESFULLYYY");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _istudents.DeleteStudent(id);
            return Ok("Record Deleted Successfully");
        }
    }
}
