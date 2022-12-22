using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harris.Models
{
    public class Enrolment
    {
        public int enrol_id { get; set; }
        public int stud_id { get; set; }
        public int class_id { get; set; }
        public DateTime enrol_date { get; set; }
    }
}
