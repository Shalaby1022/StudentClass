using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceTask
{
    internal class Person
    {
        protected string id;
        protected string fname;
        protected string lname;
        protected string address;
        protected int age;

        #region Constructors
        public Person()
        {

        }
        public Person(string id)
        {
            this.id = id;
        }

        public Person(string id, string fname, string lname)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;

        }
        public Person(string id, string fname, string lname, string address)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.address = address;

        }
        public Person(string id, string fname, string lname, string address, int age)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.age = age;
        }
        #endregion


        #region property
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Fname
        {
            get { return this.fname; }
            set { this.fname = value; }
        }
        public string Lname
        {
            get { return this.lname; }
            set { this.lname = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        #endregion

        public string Print()
        {
            return $"ID is {this.id},\n" +
                $"First name is {this.fname}\n" +
                $"Last name is {this.lname}\n" +
                $"Age is {this.age}\n" +
                $"Address is {this.address}\n";
        }


    }
}
