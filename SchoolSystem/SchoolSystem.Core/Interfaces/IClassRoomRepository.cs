using SchoolSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Core.Interfaces
{
    public interface IClassRoomRepository
    {
        void AddStudent(int classRoomId, Student student);

        void AddTeacher(int classRoomId, Teacher teacher);
        public void RemoveStudent(int classRoomId, Student student);


        public int GetStudentCount(int id);
        public int GetTeacherCount(int id);

        void AddClass(ClassRoom classroom);
        void RemoveClass(ClassRoom classroom);

        ClassRoom GetById(int id);

        IEnumerable<ClassRoom> GetAll();
        public void RemoveTeacher(int classRoomId, Teacher teacher);
    }
}
