using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceTask
{
    internal class Teacher : Person
    {
        private int salary;
        private string subject;


        #region constructors

        public Teacher() { }

        public Teacher(string id)
        {
            this.id = id;
        }
        public Teacher(string id, string fname, string lname)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;

        }
        public Teacher(string id, string fname, string lname, string address)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.address = address;

        }
        public Teacher(string id, string fname, string lname, string address, int age)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.age = age;
        }
        public Teacher(string id, string fname, string lname, string address, int age, int salary)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.age = age;
            this.salary = salary;
        }
        public Teacher(string id, string fname, string lname, string address, int age, int salary, string subject)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.age = age;
            this.salary = salary;
            this.subject = subject;
        }
        #endregion
        #region property
        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        #endregion

        public string Print()
        {
            return $"ID is {this.id},\n" +
                $"First name is {this.fname}\n" +
                $"Last name is {this.lname}\n" +
                $"Age is {this.age}\n" +
                $"Address is {this.address}\n" +
                $"Salary is {this.salary}\n" +
                $"Subject id{this.subject}\n";
        }

    }
}
