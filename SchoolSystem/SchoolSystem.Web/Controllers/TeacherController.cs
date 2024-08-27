using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Application.Services;
using SchoolSystem.Web.Models;

namespace SchoolSystem.Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly TeacherService _teacherService;

        public TeacherController(TeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        [HttpGet("/teacher/index")] 
        public IActionResult Index()
        {
            var Teachers = _teacherService.GetAllTeachers();
            var model = new TeacherViewModel
            {
                Teachers = Teachers
            };
            return View(model);
        }

        [HttpDelete("/teacher/delete/{id}")]
        public IActionResult Delete(int id)
        {
           var Teacher = _teacherService.GetTeacherById(id);
            _teacherService.RemoveTeacher(Teacher);
            return Ok();
        }

        [HttpPost("/teacher/enroll")]
        public IActionResult EnrollStudent(string name, int age, string subject, string phoneNumber, int salary)
        {
            _teacherService.AddTeacher(name, age, subject, phoneNumber, salary);
            return Ok();
        }


        [HttpGet("/teacher/add")]
        public IActionResult AddTeacher()
        {
            return View();
        }
    }
}
