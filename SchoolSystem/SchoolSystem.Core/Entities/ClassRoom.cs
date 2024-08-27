using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Core.Entities
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public List<Teacher> Teachers { get; set; }


        public ClassRoom(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Classroom name cannot be empty.");
            }

            Name = name;
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }

        

    }
}
