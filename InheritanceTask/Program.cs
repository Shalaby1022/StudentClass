namespace InheritenceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();
            readStudent(s1);
            Console.WriteLine(s1.Print());
            Teacher teacher = new Teacher();
            readTeacher(teacher);
            Console.WriteLine(teacher.Print());
        }
        static void readStudent(Student s1)
        {
            Console.WriteLine("Enter Student first name ");
            s1.Fname = Console.ReadLine();
            Console.WriteLine("Enter Student last name");
            s1.Lname = Console.ReadLine();
            Console.WriteLine("Enter Student id ");
            s1.Id = Console.ReadLine();
            Console.WriteLine("Enter Student address");
            s1.Address = Console.ReadLine();
            Console.WriteLine("Enter Student age");
            s1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student school year");
            s1.Schoolyear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student class id");
            s1.Class_id = Console.ReadLine();
        }
        static void readTeacher(Teacher t1)
        {
            Console.WriteLine("Enter Teacher first name ");
            t1.Fname = Console.ReadLine();
            Console.WriteLine("Enter Teacher last name");
            t1.Lname = Console.ReadLine();
            Console.WriteLine("Enter Teacher id ");
            t1.Id = Console.ReadLine();
            Console.WriteLine("Enter Teacher address");
            t1.Address = Console.ReadLine();
            Console.WriteLine("Enter Teacher age");
            t1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Teacher salary");
            t1.Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Teacher subject");
            t1.Subject = Console.ReadLine();
        }

    }
}