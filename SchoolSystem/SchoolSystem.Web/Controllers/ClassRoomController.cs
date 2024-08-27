using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Application.Services;
using SchoolSystem.Web.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SchoolSystem.Web.Controllers
{
    public class ClassRoomController : Controller
    {
        private readonly ClassService _classService;
        private readonly StudentService _studentService;
        private readonly TeacherService _teacherService;

        public ClassRoomController(ClassService classService, StudentService studentService, TeacherService teacherService)
        {
            _classService = classService;
            _studentService = studentService;
            _teacherService = teacherService;
        }

        [HttpGet("/ClassRoom/index")]
        public IActionResult Index()
        {
            var rooms = _classService.GetAll();
            var model = new ClassRoomViewModel
            {
                classRooms = rooms,
            };
            return View(model);
        }

        [HttpGet("ClassRoom/add")]
        public IActionResult AddClass()
        {
            return View();
        }

        [HttpPost("/ClassRoom/addclass")]
        public IActionResult AddClass(string name)
        {
            _classService.AddClass(name);
            return Ok();
        }

        [HttpDelete("/ClassRoom/delete/{id}")]
        public IActionResult Delete(int id)
        {
            _classService.RemoveClass(id);
            return Ok();
        }

        [HttpGet("/ClassRoom/students/{id}")]
        public IActionResult Students(int id)
        {
            var room = _classService.getById(id);
            if (room.Students == null || !room.Students.Any())
            {
                Console.WriteLine("empty...");
                //Environment.Exit(0);
            }

            var model = new StudentViewModel
            {
                roomid = id,
                Students = room.Students,
                Name = room.Name
            };
            return View(model);
        }

        [HttpGet("/ClassRoom/addstudents/{id}")]
        public IActionResult AddStudentsToClass(int id)
        {
            var room = _classService.getById(id);
            var students = _studentService.GetAllStudents();
            var model = new StudentViewModel
            {
                Students = students,
                room = room
            };
            return View(model);
        }

        [HttpDelete("ClassRoom/deleteStudent/{id1}/{id2}")]
        public IActionResult DeleteStudentFromClass(int id1, int id2)
        {
            var student = _studentService.GetStudentById(id1);
            var room = _classService.getById(id2);
            _classService.RemoveStudent(student, room);
            return Ok();
        }

        [HttpPost("ClassRoom/addStudenttoclass/{id1}/{id2}")]
        public IActionResult AddStudentToClass(int id1, int id2)
        {
            var student = _studentService.GetStudentById(id1);
            var room = _classService.getById(id2);
            _classService.AddStudent(student, room);
            return Ok();
        }

        [HttpGet("/ClassRoom/teachers/{id}")]
        public IActionResult Teachers(int id)
        {
            var room = _classService.getById(id);
            if (room.Teachers == null || !room.Teachers.Any())
            {
                Console.WriteLine("empty...");
                //Environment.Exit(0);
            }
            var model = new TeacherViewModel
            {
                roomid = id,
                Teachers = room.Teachers,
                Name = room.Name
            };
            return View(model);
        }
        [HttpDelete("/ClassRoom/deleteteacherfromclass/{id1}/{id2}")]
        public IActionResult DeleteteacherFromClass(int id1, int id2)
        {
            var teacher = _teacherService.GetTeacherById(id1);
            var room = _classService.getById(id2);
            _classService.RemoveTeacher(teacher, room);
            return Ok();
        }

        [HttpPost("/ClassRoom/addteachertoclass/{id1}/{id2}")]
        public IActionResult AddTeacherToClass(int id1, int id2)
        {
            var teacher = _teacherService.GetTeacherById(id1);
            var room = _classService.getById(id2);
            _classService.AddTeacher(teacher, room);
            return Ok();
        }


        [HttpGet("/ClassRoom/addteacher/{id}")]
        public IActionResult AddTeacher(int id)
        {
            var room = _classService.getById(id);
            var teachers = _teacherService.GetAllTeachers();
            var model = new TeacherViewModel
            {
               Teachers = teachers,
                room = room
            };
            return View(model);
        }
    }
}
