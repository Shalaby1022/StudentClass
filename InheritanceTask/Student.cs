using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceTask
{
    internal class Student : Person
    {
        private int schoolyear;
        private string class_id;
        #region constructors
        public Student() { }
        public Student(string id, string fname, string lname, string address, int age, int schoolyear, string class_id)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.age = age;
            this.schoolyear = schoolyear;
            this.class_id = class_id;
        }
        public Student(string id, string fname, string lname)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;

        }
        public Student(string id, string fname, string lname, string address)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.address = address;

        }
        public Student(string id, string fname, string lname, string address, int age)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.age = age;

        }
        #endregion
        #region property
        public int Schoolyear
        {
            get { return schoolyear; }
            set { schoolyear = value; }
        }
        public string Class_id
        {
            get { return class_id; }
            set { class_id = value; }
        }
        #endregion
        public string Print()
        {
            return $"ID is {this.id},\n" +
                $"First name is {this.fname}\n" +
                $"Last name is {this.lname}\n" +
                $"Age is {this.age}\n" +
                $"Address is {this.address}\n" +
                $"School year is {this.schoolyear}\n" +
                $"Class_id id{this.class_id}\n";
        }


    }
}
