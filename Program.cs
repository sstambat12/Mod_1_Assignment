using System;

namespace Mod_1_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string first;
            string last;
            DateTime birthdate;
            string add1;
            string add2;
            string city;
            string state;
            int zip;
            string country;
            Console.WriteLine("Enter the First Name of Student ->");
            first = Console.ReadLine();
            Console.WriteLine("Enter the Last Name of Student ->");
            last = Console.ReadLine();
            Console.WriteLine("Enter the Bithdate of Student ->");
            birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Address of the Student ->");
            Console.WriteLine("Address Line 1 ->");
            add1 = Console.ReadLine();
            Console.WriteLine("Address Line 2 ->");
            add2 = Console.ReadLine();
            Console.WriteLine("City ->");
            city = Console.ReadLine();
            Console.WriteLine("State ->");
            state = Console.ReadLine();
            Console.WriteLine("Zip/Postal ->");
            zip = int.Parse(Console.ReadLine());
            Console.WriteLine("Country ->");
            country = Console.ReadLine();
            Console.WriteLine("||| STUDENT INFORMATION |||");
            Console.WriteLine("Name-> {0} {1}", first, last);
            Console.WriteLine("Birthdate-> {0}", birthdate);
            Console.WriteLine("Address-> {0}, {1}, {2}, {3}, {4}, {5}", add1, add2, city, state, zip, country);

            // TEACHER INFORMATION
            Console.WriteLine("Enter the First Name of Teacher ->");
            first = Console.ReadLine();
            Console.WriteLine("Enter the Last Name of Teacher ->");
            last = Console.ReadLine();
            Console.WriteLine("Enter the Bithdate of Teacher ->");
            birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Address of the Teacher ->");
            Console.WriteLine("Address Line 1 ->");
            add1 = Console.ReadLine();
            Console.WriteLine("Address Line 2 ->");
            add2 = Console.ReadLine();
            Console.WriteLine("City ->");
            city = Console.ReadLine();
            Console.WriteLine("State ->");
            state = Console.ReadLine();
            Console.WriteLine("Zip/Postal ->");
            zip = int.Parse(Console.ReadLine());
            Console.WriteLine("Country ->");
            country = Console.ReadLine();
            PrintTeacherInfo(first, last, birthdate, add1, add2, city, state, zip, country);

            //UPROGRAM INFORMATION
            string programName;
            string departmentHead;
            Console.WriteLine("Enter the Program Name ->");
            programName = Console.ReadLine();
            Console.WriteLine("Enter the Department Head Name ->");
            departmentHead = Console.ReadLine();
            Console.WriteLine("Enter the Number of Degrees ->");
            int count = int.Parse(Console.ReadLine());
            string[] deg = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the {0} degree Name ->", i);
                deg[i] = Console.ReadLine();
            }
            PrintProgramInfo(programName, departmentHead, deg);

            //DEGREE INFORMATION

            string degreeName;
            int credits;
            Console.WriteLine("Enter the Degree Name ->");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter the Creadits Required for the Degree you have entered ->");
            credits = int.Parse(Console.ReadLine());
            PrintDegreeInfo(degreeName, credits);

            //COURSE INFORMATION

            string courseName;
            //int credits;
            int duration;
            string teacher;
            Console.WriteLine("Enter the Course Name ->");
            courseName = Console.ReadLine();
            Console.WriteLine("Enter the Creadits Required for the Course you have entered ->");
            credits = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the duration in Weeks for the Course you have entered ->");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Course Name ->");
            teacher = Console.ReadLine();
            PrintCourseInfo(courseName, credits, duration, teacher);
        }
        public static void PrintTeacherInfo(string first, string last, DateTime birthdate, string add1,
                                            string add2, string city, string state, int zip, string country)
        {
            Console.WriteLine("||| TEACHER INFORMATION |||");
            Console.WriteLine("Name-> {0} {1}", first, last);
            Console.WriteLine("Birthdate-> {0}", birthdate);
            Console.WriteLine("Address-> {0}, {1}, {2}, {3}, {4}, {5}", add1, add2, city, state, zip, country);

        }
        private static void PrintCourseInfo(string courseName, int credits, int duration, string teacher)
        {
            Console.WriteLine("||| COURSE INFORMATION");
            Console.WriteLine("Course Name -> {0} & Credits -> {1}", courseName, credits);
            Console.WriteLine("Duration in Weeks -> {0} And Teacher -> {1}", duration, teacher);
        }
    

        private static void PrintDegreeInfo(string degreeName, int credits)
        {
            Console.WriteLine("||| DEGREE INFORMATION");
            Console.WriteLine("Degree Name -> {0} & Credits Required ->{1}", degreeName, credits);
        }
    
        public static void PrintProgramInfo(string programName, string departmentHead, string[] degs)
        {
            Console.WriteLine("||| UPROGRAM INFORMATION |||");
            Console.WriteLine("Program Name -> {0} \n Department Head-> {1}", programName, departmentHead);
            Console.WriteLine("Degrees ->");
            for (int i = 0; i < degs.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i, degs[i]);
            }

        }

    

        
    }
    
}
