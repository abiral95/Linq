using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Linq
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Teacher> GetAllTeachers()
        {
            List<Teacher> listTeachers = new List<Teacher>();

            Teacher teacher1 = new Teacher
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };
            listTeachers.Add(teacher1);

            Teacher teacher2 = new Teacher
            {
                ID = 102,
                Name = "Mary",
                Gender = "Female"
            };
            listTeachers.Add(teacher2);

            Teacher teacher3 = new Teacher
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };
            listTeachers.Add(teacher3);

            Teacher teacher4 = new Teacher
            {
                ID = 104,
                Name = "Steve",
                Gender = "Male"
            };
            listTeachers.Add(teacher4);

            Teacher teacher5 = new Teacher
            {
                ID = 105,
                Name = "Pam",
                Gender = "Female"
            };
            listTeachers.Add(teacher5);

            return listTeachers;
        }
    }
}