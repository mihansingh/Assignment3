using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C0709255
{
    public delegate void Sort_DataStructure();
    class Program
    {
        static void Main(string[] args)
        {
            DataStructureStack a = new DataStructureStack();
            a.Run();


            Student s1 = new Student();
            s1.Announcement();
            AverageStudentGPA();


            Console.ReadLine();

        }
        static void AverageStudentGPA()
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();
            Student student5 = new Student();

            ArrayList stu = new ArrayList();
            stu.Add(student1);
            stu.Add(student2);
            stu.Add(student3);
            stu.Add(student4);
            stu.Add(student5);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(stu[0]);
            }
        }

    }

    class Student
    {
        String Student_name;
        String StudentID;
        double StudentGPA;

        // TODO: change this implementation so that the program pulls names from a Text File:
        // to do this, you must change the container for Student Names from Array to List
        String[] names = new String[5] { "Bill", "Mary", "Laura", "Sam", "Steve" };
        Random r1;

        public Student()
        {
            r1 = new Random();
            Student_name = names[r1.Next(0, 4)];
            StudentID = Convert.ToString(r1.Next(1000, 9999));
            StudentGPA = Convert.ToDouble(r1.Next(1, 99));
        }


        public void Announcement()
        {


            try
            {
                using (StreamReader sr = new StreamReader("U:/Users/709255/names.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public double AverageStudentGPA()
        {
            double sum = 0;
            // TO DO: implement the algorithm to calculate the Students' average GPA
            for (int i = 0; i < names.Length; i++)
            {
                sum += StudentGPA;
            }
            return StudentGPA;
        }

    }
}