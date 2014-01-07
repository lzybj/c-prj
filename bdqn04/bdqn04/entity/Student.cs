using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn04.entity
{
    public class Student
    {
        private string stuNo;

        public string StuNo
        {
            get { return stuNo; }
            set { stuNo = value; }
        }
        private int stuAge;

        public int StuAge
        {
            get { return stuAge; }
            set { stuAge = value; }
        }
        private string stuName;

        public string StuName
        {
            get { return stuName; }
            set { stuName = value; }
        }
        public Student(int stuAge,string stuName)
        {
            this.stuNo = "0000";
            this.stuAge = stuAge;
            this.stuName = stuName;
        }
        public Student(string stuNo,int stuAge,string stuName)
        {
            this.stuNo = stuNo;
            this.stuAge = stuAge;
            this.stuName = stuName;
        }
        public Student()
        {

        }
        public Student(string stuNo,string stuName)
        {
        }
    }
}
