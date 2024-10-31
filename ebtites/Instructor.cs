using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SESSION_1_ASSIGNMENT.entites
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int bouns { get; set; }
        public double salary { get; set; }

        public string address { get; set; }
        public int HourRate { get; set; }
        public int Dept_id { get; set; }
    }
}
