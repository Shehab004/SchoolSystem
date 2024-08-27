using SchoolSystem.Core.Entities;
using System.Threading.Tasks;

namespace SchoolSystem.Core.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        Student GetById(int id);
        void Remove(Student student);
        IEnumerable<Student> GetAll();
   

    }
}
