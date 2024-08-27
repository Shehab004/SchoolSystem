using SchoolSystem.Core.Entities;
using SchoolSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Application.Services
{
    public class ClassService
    {
        private readonly IClassRoomRepository _roomRepository;
        public ClassService(IClassRoomRepository roomRepository) 
        {
           _roomRepository = roomRepository;
        }

        public void AddClass(string name)
        {
            var room = new ClassRoom(name);
            _roomRepository.AddClass(room);
        }

        public void RemoveClass(int id)
        {
            var room = _roomRepository.GetById(id);
            _roomRepository.RemoveClass(room);
        }

        public int GetStudentCount(ClassRoom room)
        {
            int id = room.Id;
            return _roomRepository.GetStudentCount(id);
        }

        public int GetTeacherCount(ClassRoom room)
        {
            int id = room.Id;
            return _roomRepository.GetTeacherCount(id);
        }
        public ClassRoom getById(int id)
        {
            return _roomRepository.GetById(id);
        }

        public IEnumerable<ClassRoom> GetAll()
        { 
            return _roomRepository.GetAll();
        }

        public void AddStudent(Student student, ClassRoom room)
        {
            int id = room.Id;
            _roomRepository.AddStudent(id, student);
        }

        public void RemoveStudent(Student student, ClassRoom room)
        {
            int id = room.Id;
            _roomRepository.RemoveStudent(id, student);
        }

        public void RemoveTeacher(Teacher teacher, ClassRoom room)
        {
            int id = room.Id;
            _roomRepository.RemoveTeacher(id, teacher);
        }

        public void AddTeacher(Teacher teacher, ClassRoom room)
        {
            int id = room.Id;
            _roomRepository.AddTeacher(id, teacher);
        }
    }
}
