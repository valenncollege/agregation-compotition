using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academic_System
{
    public class Teacher
    {
        private string name;
        private string id;

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }

        public Teacher(string pName, string pId)
        {
            this.Name = pName;
            this.Id = pId;
        }

        public string DisplayTeacher()
        {
            string result = "Teacher's ID : " + this.Id + "\n" +
                "Teacher's Name : " + this.Name + "\n";
            return result;
        }
    }
}