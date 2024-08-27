using SchoolSystem.Core.Entities;

namespace SchoolSystem.Web.Models
{
    public class TeacherViewModel
    {
        public IEnumerable<Teacher>? Teachers { get; set; }
        public string Name { get; set; }
        public int roomid { get; set; }
        public ClassRoom room { get; set; }
    }
}
