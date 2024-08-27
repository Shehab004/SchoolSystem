using SchoolSystem.Core.Entities;
using SchoolSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Application.Services
{
    public class TeacherService
    {
        public readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public void AddTeacher(string name, int age, string subject, string phoneNumber, int salary)
        {
            Teacher teacher = new Teacher(name, age, subject, phoneNumber, salary);
            _teacherRepository.AddTeacher(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
           
            _teacherRepository.RemoveTeacher(teacher);
        }

        public Teacher GetTeacherById(int id)
        {
          return  _teacherRepository.GetTeacherById(id);
        }

         public IEnumerable<Teacher> GetAllTeachers()
        {
           return _teacherRepository.GetAll();
        }
    }


}
