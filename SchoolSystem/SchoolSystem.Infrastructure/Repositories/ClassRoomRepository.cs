using Microsoft.EntityFrameworkCore;
using SchoolSystem.Core.Entities;
using SchoolSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Infrastructure.Repositories
{
    public class ClassRoomRepository : IClassRoomRepository
    {
        private readonly SchoolDbContext _context;

        public ClassRoomRepository(SchoolDbContext context)
        {
            _context = context;
        }
        public void AddStudent(int classRoomId, Student student)
        {
            var classroom = _context.Classes
                                    .Include(c => c.Students)
                                    .FirstOrDefault(c => c.Id == classRoomId);

            if (classroom != null)
            {
                classroom.Students.Add(student);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Classroom not found.");
            }
        }
        public void RemoveStudent(int classRoomId, Student student)
        {
            var classroom = _context.Classes
                                    .Include(c => c.Students)
                                    .FirstOrDefault(c => c.Id == classRoomId);

            if (classroom != null)
            {


                    classroom.Students.Remove(student);
                    _context.SaveChanges();
                }
 
            else
            {
                throw new Exception("Classroom not found.");
            }
        }
        public int GetStudentCount(int classRoomId)
        {
            var classroom = _context.Classes
                                    .Include(c => c.Students)
                                    .FirstOrDefault(c => c.Id == classRoomId);

            if (classroom != null)
            {
                return classroom.Students.Count;
            }
            else
            {
                throw new Exception("Classroom not found.");
            }
        }

        public int GetTeacherCount(int classRoomId)
        {
            var classroom = _context.Classes
                                    .Include(c => c.Teachers)
                                    .FirstOrDefault(c => c.Id == classRoomId);

            if (classroom != null)
            {
                return classroom.Teachers.Count;
            }
            else
            {
                throw new Exception("Classroom not found.");
            }
        }

        public void AddClass(ClassRoom classroom)
        {
            _context.Classes.Add(classroom);
            _context.SaveChanges ();
        }

        public void RemoveClass(ClassRoom classroom)
        {
            _context.Classes.Remove(classroom);
            _context.SaveChanges ();
        }
        public ClassRoom GetById(int id)
        {
            var classroom = _context.Classes
                                  .Include(c => c.Students)
                                  .Include(c => c.Teachers)
                                  .FirstOrDefault(c => c.Id == id);
            return classroom;
        }

        public IEnumerable<ClassRoom> GetAll()
        {
            var Classes = _context.Classes.Include(c => c.Students).Include(c => c.Teachers).ToList();
            return Classes;
        }

        public void RemoveTeacher(int classRoomId, Teacher teacher)
        {
            var classroom = _context.Classes
                                    .Include(c => c.Teachers)
                                    .FirstOrDefault(c => c.Id == classRoomId);

            if (classroom != null)
            {


                classroom.Teachers.Remove(teacher);
                _context.SaveChanges();
            }

            else
            {
                throw new Exception("Classroom not found.");
            }
        }

        public void AddTeacher(int classRoomId, Teacher teacher)
        {
            var classroom = _context.Classes
                                    .Include(c => c.Teachers)
                                    .FirstOrDefault(c => c.Id == classRoomId);

            if (classroom != null)
            {
                classroom.Teachers.Add(teacher);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Classroom not found.");
            }
        }
    }
}
