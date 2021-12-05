using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS155ECStudentGrades
{

    class Course
    {
        const double FINALS_WEIGHT = 0.4;
        const double FINALS_OUTOF = 100.0;
        const double MIDTERM_WEIGHT = 0.35;
        const double MIDTERM_OUTOF = 100.0;
        const double QUIZZES_WEIGHT = 0.25;
        const double EACHQUIZ_OUTOF = 10.0;
        const int NUM_QUIZZES = 3;

        private String term;
        private String title;
        private String instructor;
        private String schedule;

        private double[] quizscores = new double[3];
        private double finalsscore;
        private double midtermscore;

        private double grade;

        public Course()
        {
            term = "";
            title = "";
            instructor = "";
            schedule = "";

            finalsscore = 0.0;
            midtermscore = 0.0;
            for (int i = 0; i < NUM_QUIZZES; i++)
                quizscores[i] = 0.0;
            grade = 0.0;
        }

        public Course(String t, String ct, String inst, String s)
        {
            term = t;
            title = ct;
            instructor = inst;
            schedule = s;

            finalsscore = 0.0;
            midtermscore = 0.0;
            for (int i = 0; i < NUM_QUIZZES; i++)
                quizscores[i] = 0.0;
            grade = 0.0;
        }

        public String Term { get => term; set => term = value; }
        public String Title { get => title; set => title = value; }
        public String Instructor { get => instructor; set => instructor = value; }
        public String Schedule { get => schedule; set => schedule = value; }

        public double FinalsScore { get => finalsscore; set => finalsscore = value; }
        public double MidTermScore { get => midtermscore; set => midtermscore = value; }
        public void setQuizScores(double[] arr)
        {
            for (int i = 0; i < NUM_QUIZZES; i++)
                quizscores[i] = arr[i];
        }


        public void addGrade(double g) { grade += g; }

        public double getNumericGrade() 
        {
            updateNumericgrade();
            return grade; 
        }

        private void updateNumericgrade()
        {
            double quizSum = 0.0;
            double quizAverage = 0.0;
            for (int i = 0; i < NUM_QUIZZES; i++)
                quizSum += quizscores[i] / EACHQUIZ_OUTOF * 100.0;
            quizAverage = quizSum / NUM_QUIZZES;

            grade = finalsscore * FINALS_WEIGHT + midtermscore * MIDTERM_WEIGHT + quizAverage * QUIZZES_WEIGHT;

        }

        
        public String getLetterGrade()
        {
            double g = getNumericGrade();
            if (g >= 90.0)
                return "A";
            else if (g >= 80.0)
                return "B";
            else if (g >= 70.0)
                return "C";
            else if (g >= 60.0)
                return "D";
            else 
                return "F";

        }

        public override String ToString()
        {
            String sq="";
            for (int i = 0; i<NUM_QUIZZES; i++)
            {
                sq += string.Format("{0:N1}", quizscores[i]) + "  ";
            }

            String s;
            s = title + " \n" + instructor + " \n" + schedule + " \n" + 
                "Quiz scores:        " + sq + " \n" +
                "Mid-term score:     " + string.Format("{0:N2}%", midtermscore) + " \n" +
                "Final score:        " + string.Format("{0:N2}%", finalsscore) + " \n" +
                "Weighted Avg Score: " + string.Format("{0:N2}%", getNumericGrade())  + " \n" + "Grade:              " + getLetterGrade() + " \n";
            return s;
        }
        public bool Equals(Course objC)
        {
            return ((objC.Title == title) && (objC.Instructor == instructor) && (objC.Schedule == schedule));
        }
    }
    
}
