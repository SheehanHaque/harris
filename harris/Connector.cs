using harris.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harris
{
    public class Connector
    {
        private string connString = "Server= harrisdb.c78geddwswup.us-east-1.rds.amazonaws.com;User ID=Admin;Password=Jonjones11!;Database=HarrisDB";
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("Call sp_GetStudents()", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Student_id = reader.GetInt32(0),
                            gender_id = reader.GetInt32(1),
                            address_id = reader.GetInt32(2),
                            class_id = reader.GetInt32(3),
                            enrol_id = reader.GetInt32(4)
                        });
                    }
            }
            return students;
        }
    }
}
