namespace Lab5

{
    internal class StudentClass
    {
        public class Student
        {
            private string ssn;
            private string name;
            private int age;
            private string address;

            public string SSN
            {
                get { return ssn; }
                set { ssn = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            public Student()
            {
                ssn = "";
                name = "";
                age = 0;
                address = "";
            }

            public Student(string ssn, string name, int age, string address)
            {
                this.ssn = ssn;
                this.name = name;
                this.age = age;
                this.address = address;
            }

            public string Print()
            {
                return $" Ssn is {SSN} , Name is {Name} , Age is {Age} , Adress is: {Address}";

            }
        }
        static void Main(string[] args)
        {
            int numberOfStudents = 0;
            int studentCountToNotify = 10;

            Console.WriteLine("Enter data for a single student:");
            Console.Write("SSN: ");
            string ssn = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Student singleStudent = new Student(ssn, name, age, address);

            Console.WriteLine("\nStudent Details:");
            Console.WriteLine(singleStudent.Print()); 

            Console.WriteLine("\nEnter the number of students: ");
            numberOfStudents = int.Parse(Console.ReadLine());


            Student[] students = new Student[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("\nEnter details for Student " + (i + 1) + ":");
                Console.Write("SSN: ");
                ssn = Console.ReadLine();

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Age: ");
                 age = int.Parse(Console.ReadLine());

                Console.Write("Address: ");
                address = Console.ReadLine();

                students[i] = new Student(ssn, name, age, address);

                if ((i + 1) % studentCountToNotify == 0)
                {
                    Console.WriteLine("Notifying the school... " + (i + 1) + " students' data submitted.");
                }
            }

            Console.WriteLine("\nStudent Details:");
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("\nDetails of Student " + (i + 1) + ":");
                Console.WriteLine(students[i].Print());
            }
        }
    }

}