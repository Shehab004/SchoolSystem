using SchoolSystem.Application.Services;
using SchoolSystem.Core.Entities;
namespace SchoolSystem.Web.Models
{
    public class ClassRoomViewModel
    {
        public IEnumerable<ClassRoom> classRooms { get; set; }
    }
}
