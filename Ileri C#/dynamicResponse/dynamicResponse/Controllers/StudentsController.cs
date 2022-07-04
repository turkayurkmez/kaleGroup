using dynamicResponse.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dynamicResponse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = new List<Student>()
            {
                new Student{ Id=1, Name="Student A", Age=25, Info="Test Info 1"},
                new Student{ Id=2, Name="Student B", Age=25, Info="Test Info 2"},
                new Student{ Id=3, Name="Student C", Age=25, Info="Test Info 3"},
                new Student{ Id=5, Name="Student D", Age=25, Info="Test Info 4"}

            };

            dynamic result = students.Select(st=> new { st.Id, st.Name, st.Age});

            return Ok(result);

        }
    }
}
