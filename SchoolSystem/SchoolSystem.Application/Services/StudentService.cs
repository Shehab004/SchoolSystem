using SchoolSystem.Core.Entities;
using SchoolSystem.Core.Interfaces;
using System;

namespace SchoolSystem.Application.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void EnrollStudent(string name, string phoneNumber, string parentNumber, string address, decimal degree)
        {
            var student = new Student(name, phoneNumber, parentNumber, address, degree);
            _studentRepository.Add(student);
        }


        public Student GetStudentById(int id)
        {
            return _studentRepository.GetById(id);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }

        public void remove(int id)
        {
            var student = GetStudentById(id);
            _studentRepository.Remove(student);
        }
    }
}
