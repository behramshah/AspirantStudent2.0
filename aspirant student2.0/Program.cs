using System;

namespace StudentAspirant
{
    class Program
    {
        static void Main(string[] args)
        {
            SDatabase stbase = new SDatabase();
            AsDatabase astbase = new AsDatabase();

            string choice; link1:

            Console.WriteLine("For new student type - 1");
            Console.WriteLine("For new aspirant- 2 ");
            Console.WriteLine("For information about Students-3");
            Console.WriteLine("For information about Aspirants-4");
            Console.WriteLine("Type -end- to exit");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateStudent(); goto link1;
                    break;
                case "2":
                    CreateAspirant(); goto link1;
                    break;
                case "3":
                    CreateStudent(); goto link1;
                    break;
                case "4":
                    CreateAspirant(); goto link1;
                    break;
                case "end":

                    break;
            }




            Console.ReadKey();
        }

        public static string CreateStudent()
        {
            String surname = null;
            int year = 0;
            int number = 0;
            SDatabase stbase = new SDatabase();
            int n = 0;//counter student
            string choice = "1";
            while (choice == "1")
            {

                Console.WriteLine("type surname");
                surname = Console.ReadLine();
                Console.WriteLine("type study year");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("type student number");
                number = Convert.ToInt32(Console.ReadLine());
                stbase[n] = new Student(surname, year, number);
                n = n + 1;
                Console.WriteLine("For new student type - 1 \t  For new aspirant- 2 \t For Students information -3 \t For Aspirant information -4 \t Type -end- to exit");
                choice = Console.ReadLine();

            }
            while (choice == "3")
            {
                Console.WriteLine("Enter index");
                int m = Convert.ToInt32(Console.ReadLine());
                stbase[m].Display();
                Console.WriteLine("For new student type - 1 \t Type - end - to exit \t For new aspirant- 2 \t For information -3 \t For Students information -4 \t Type -end- to exit ");
                choice = Console.ReadLine();
            }
            return choice;


        }
        public static string CreateAspirant()
        {
            String surname = null;
            int year = 0;
            int number = 0;
            String thesis = null;
            AsDatabase astbase = new AsDatabase();
            int n = 0;//counter aspirant
            string choice = "2";
            while (choice == "2")
            {
                Console.WriteLine("type surname");
                surname = Console.ReadLine();
                Console.WriteLine("type study year");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("type student number");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("type Thesis theme");
                thesis = Console.ReadLine();
                astbase[n] = new Aspirant(surname, year, number, thesis);
                n = n + 1;
                Console.WriteLine("For new student type - 1 \t  For new aspirant- 2 \t For Student information -3 \t For Aspirant information -4 \t Type -end- to exit ");
                choice = Console.ReadLine();
            }
            while (choice == "4")
            {
                Console.WriteLine("Enter index");
                int m = Convert.ToInt32(Console.ReadLine());
                astbase[m].Display();
                Console.WriteLine("For new student type - 1 \t Type - end - to exit \t For new aspirant- 2 \t For information -3 \t For Students information -4 \t Type -end- to exit ");
                choice = Console.ReadLine();
            }
            return choice;
        }




    }
    public class Student
    {
        string surname;
        int yearstudy;
        int studentnumber;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public Student(string surname) { Surname = surname; }
        public int YearStudy
        {
            get { return yearstudy; }
            set { yearstudy = value; }
        }
        public int StudentNumber
        {
            get { return studentnumber; }
            set { studentnumber = value; }
        }
        public Student(string surname, int yearstudy, int studentnumber) { Surname = surname; YearStudy = yearstudy; StudentNumber = studentnumber; }

        public virtual void Display()
        {
            Console.WriteLine($"Student={Surname} Year={YearStudy} Number={StudentNumber} ");
        }
    }
    public class Aspirant : Student
    {
        string thesis;
        public string Thesis
        {
            get { return thesis; }
            set { thesis = value; }
        }

        public Aspirant(string surname, int yearstudy, int studentnumber, string thesis) : base(surname, yearstudy, studentnumber) { Thesis = thesis; }
        public override void Display()
        {
            base.Display();
            Console.Write($" Works on {Thesis} ");
        }
    }
    public class SDatabase
    {
        Student[] data;
        public SDatabase()
        {
            data = new Student[99];
        }
        public Student this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }



    }
    public class AsDatabase
    {
        Aspirant[] asdata;
        public AsDatabase()
        {
            asdata = new Aspirant[99];
        }
        public Aspirant this[int index]
        {
            get
            {
                return asdata[index];
            }
            set
            {
                asdata[index] = value;
            }
        }



    }

}
