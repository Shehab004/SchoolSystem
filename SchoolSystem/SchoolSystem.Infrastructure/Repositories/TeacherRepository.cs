using SchoolSystem.Core.Entities;
using SchoolSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Infrastructure.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly SchoolDbContext _context;

        public TeacherRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public void AddTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
        }

        public void RemoveTeacher(Teacher teacher)
        {
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
        }

        public Teacher GetTeacherById(int id)
        {
            return _context.Teachers.Find(id);
        }


        public IEnumerable<Teacher> GetAll()
        {
            var Teachers = _context.Teachers.ToList();
            return Teachers;
        }
    }
}
