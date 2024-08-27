using SchoolSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Core.Interfaces
{
    public interface ITeacherRepository
    {
       void AddTeacher(Teacher teacher);
       void RemoveTeacher (Teacher teacher);
       Teacher GetTeacherById (int id);

       IEnumerable<Teacher> GetAll();
    }
}
