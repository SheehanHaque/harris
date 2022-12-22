using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harris.Models
{
    public class Student
    {
        public int Student_id { get; set; }
        public string stud_fname { get; set; }
        public string stud_lname { get; set; }
        public string stud_email { get; set; }
        public DateTime stud_dob { get; set; }
        public int gender_id { get; set; }
        public int address_id { get; set; }
        public int class_id { get; set; }
        public int enrol_id { get; set; }
    }
    
}
