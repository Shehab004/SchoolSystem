using Microsoft.EntityFrameworkCore;
using SchoolSystem.Core.Entities;
using SchoolSystem.Core.Interfaces;

namespace SchoolSystem.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDbContext _context;

        public StudentRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        public Student GetById(int id)
        {
            return _context.Students.Find(id);
        }

        public void Remove(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public IEnumerable<Student> GetAll()
        {
            var students = _context.Students.ToList();
            return students;
        }



    }
}
