using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SESSION_1_ASSIGNMENT.entites
{
    internal class Course_inst
    {
        [Key]
        public int inst_id { get; set; }
        public int Coure_id { get; set; }
        public string evaluate { get; set; }
    }
}
