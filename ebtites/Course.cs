using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SESSION_1_ASSIGNMENT.entites
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Duration { get; set; }
        public int Top_id { get; set; }
    }
}
