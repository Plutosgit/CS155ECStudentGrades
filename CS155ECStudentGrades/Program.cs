using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS155ECStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Students Grade Calculator");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            const int MAX_COURSES = 5;
            double[] quizS = new double[3];

            //Student #1

            Student myStudent = new Student("Balaji V","123-45-6789"); //Create new Student record

            //Course #1

            Course c1 = new Course("Fall2021", "C# Fundamentals", "Mark Aloka", "M, W 530-830pm");

            quizS[0] = 10.0;
            quizS[1] = 10;
            quizS[2] = 9.0;

            c1.setQuizScores(quizS);

            c1.FinalsScore = 70.0;
            c1.MidTermScore = 82.0;

            myStudent.AddCourse(c1);

            //Course #2
            Course c2 = new Course("Fall2021", "Networking Fundamentals", "G Ward", "T, Th 530-830pm");

            quizS[0] = 7.0;
            quizS[1] = 9;
            quizS[2] = 8.0;

            c2.setQuizScores(quizS);

            c2.FinalsScore = 80.0;
            c2.MidTermScore = 92.0;

            myStudent.AddCourse(c2);

            // Now, use ToString to print out all the courses for this student..
            Console.WriteLine(myStudent.ToString());

            // Get the student's semester GPA..
            Console.WriteLine("Semester GPA =      " + string.Format("{0:N2}", myStudent.getSemesterGPA()));

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();

            // ***************************************************************************
            //Student #2

            //Student #1

            Student myStudent2 = new Student("Peter B", "987-65-4321"); //Create new Student record

            //Course #1

            c1 = new Course("Fall2021", "Macro Economics", "Steve M.", "MWF 500-600pm");

            quizS[0] = 10.0;
            quizS[1] = 10;
            quizS[2] = 10.0;

            c1.setQuizScores(quizS);

            c1.FinalsScore = 90.0;
            c1.MidTermScore = 92.0;

            myStudent2.AddCourse(c1);

            //Course #2
            c2 = new Course("Fall2021", "Marketing Research", "Lisa G.", "T, Th 630-830pm");

            quizS[0] = 7.0;
            quizS[1] = 9;
            quizS[2] = 10.0;

            c2.setQuizScores(quizS);

            c2.FinalsScore = 94.0;
            c2.MidTermScore = 88.0;

            myStudent2.AddCourse(c2);

            //Course #3
            Course c3 = new Course("Fall2021", "Accounting Principles", "Megan T.", "MWF 830-930am");

            quizS[0] = 8.0;
            quizS[1] = 8;
            quizS[2] = 10.0;

            c3.setQuizScores(quizS);

            c3.FinalsScore = 74.0;
            c3.MidTermScore = 83.0;

            myStudent2.AddCourse(c3);

            // Now, use ToString to print out all the courses for this student..
            Console.WriteLine(myStudent2.ToString());

            // Get the student's semester GPA..
            Console.WriteLine("Semester GPA =      " + string.Format("{0:N2}", myStudent2.getSemesterGPA()));

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
