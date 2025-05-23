using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academic_System
{
    public class Subject
    {
        private string id;
        private string name;
        private int sks;
        private List<Teacher> listTeacher;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Sks { get => sks; set => sks = value; }
        public List<Teacher> ListTeacher { get => listTeacher; private set => listTeacher = value; }

        public Subject(string pId, string pName, int pSks)
        {
            this.Id = pId;
            this.Name = pName;
            this.Sks = pSks;
            this.ListTeacher = new List<Teacher>();
        }

        public string DisplaySubject()
        {
            string result = "Subject ID : " + this.Id + "\n" +
                "Subject Name : " + this.Name + "\n" +
                "Credit : " + this.Sks + "\n" + "\n" +
                "List Teacher : " + this.DisplayListTeacher();
            return result;
        }

        public string DisplayListTeacher()
        {
            string result = "";
            foreach(Teacher i in this.ListTeacher)
            {
                result = result + i.Name + "\n";
            }
            return result;
        }

    }
}