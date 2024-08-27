using SchoolSystem.Core.Entities;

namespace SchoolSystem.Web.Models
{
    public class StudentViewModel
    {
        public IEnumerable<Student>? Students { get; set; }
        public string? Name { get; set; }
        public ClassRoom? room { get; set; }
        public Student? Student { get; set; }
        public int? roomid { get; set; }
    }
}
