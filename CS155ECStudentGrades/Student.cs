using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS155ECStudentGrades
{
    class Student
    {
        const int MAX_COURSES = 5;

        private String name;
        private String ssn;

        private Course[] courses = new Course[MAX_COURSES];
        private double semesterGPA;
        private int numCourses;

        public Student()
        {
            name = "";
            ssn = "";
            numCourses = 0;
            for (int i = 0; i < MAX_COURSES ; i++)
            {
                courses[i] = new Course("", "", "", "");
            }
        }

        public Student(String n, String s)
        {
            name = n;
            ssn = s;
            numCourses = 0;

            for (int i = 0; i < MAX_COURSES; i++)
            {
                courses[i] = new Course("", "", "", "");
            }
 
        }

        public int getNumCourses() { return numCourses; }

        public bool AddCourse(Course c)
        {
            if (numCourses == MAX_COURSES)
                return false;

            courses[numCourses] = c;
            numCourses++;               //Increment numCourses

            return true;
        }

        public override String ToString()
        {
            String s = "";
            s = s + "Name: " + name + "  | " + "SSN: " + ssn + "  | " + "Number of courses: " + numCourses.ToString() + "\n" ;
            for (int i = 0; i < numCourses; i++)
            {
                s = s  +"\n" + courses[i];
            }

            return s;
        }

        public double getSemesterGPA()
        {
            calcSemesterGPA();
            return semesterGPA;
        }

        private void calcSemesterGPA()
        {
            double sum = 0.0;
            for (int i = 0; i < numCourses; i++)
            {
                switch (courses[i].getLetterGrade())
                {
                    case "A":
                        sum += 4.0;
                        break;
                    case "B":
                        sum += 3.0;
                        break;
                    case "C":
                        sum += 2.0;
                        break;
                    case "D":
                        sum += 1.0;
                        break;
                   default:
                        sum += 0.0;
                        break;
                }
            }

            semesterGPA = sum / numCourses;
        }
    }
}
