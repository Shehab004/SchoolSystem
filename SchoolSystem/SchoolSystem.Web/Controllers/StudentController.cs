using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Application.Services;
using SchoolSystem.Web.Models;

namespace SchoolSystem.Web.Controllers
{
    [Route("student")] // Adjust this route if necessary
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("add")]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost("enroll")]
        public IActionResult EnrollStudent([FromBody] StudentDto studentDto)
        {
            if (studentDto == null)
            {
                return BadRequest("Invalid student data.");
            }

            _studentService.EnrollStudent(studentDto.Name, studentDto.PhoneNumber, studentDto.ParentNumber, studentDto.Address, studentDto.Degree);
            return Ok();
        }
 


        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpGet("index")] // URL will be /student/index
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents(); // Get all students
            var model = new StudentViewModel
            {
                Students = students
            };
            return View(model);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _studentService.remove(id);
            return Ok();
        }

    }
}
