using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace otherprj2.entity
{
    public class Student
    {
        private string stuno;

        public string Stuno
        {
            get { return stuno; }
            set { stuno = value; }
        }
        private string stuname;

        public string Stuname
        {
            get { return stuname; }
            set { stuname = value; }
        }
        public Student(string stuno,string stuname)
        {
            this.stuno = stuno;
            this.stuname = stuname;
        }
    }
}
