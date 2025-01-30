// YUWENYOH ANKINIOMBOM NFI
// 1/27/2025

using System;
namespace QuizCalculator
{
    public class QuizCalculatorA
    {
        // creating variables
        private double quiz1 = -100.00;
        private double quiz2 = -100.00;
        private double quiz3 = -100.00;
        private double quiz4 = -100.00;
        private double total = -100000.00;
        private double average = -100.00;
        private string lettergrade = "n/a";

        // gets and sets
        public double Quiz1
        {
            get { return this.quiz1; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz1 = -100.0;
                }
                else
                {
                    this.quiz1 = value;
                }
            }

        }

        public double Quiz2
        {
            get { return this.quiz2; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz2 = -100.0;
                }
                else
                {
                    this.quiz2 = value;
                }
            }

        }

        public double Quiz3
        {
            get { return this.quiz3; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz3 = -100.0;
                }
                else
                {
                    this.quiz3 = value;
                }
            }

        }


        public double Quiz4
        {
            get { return this.quiz4; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz4 = -100.0;
                }
                else
                {
                    this.quiz4 = value;
                }
            }

        }

        //list
        //private List<double> QuizList = new List<double>
        //public void AddQuiz(double aQuiz)
        /*{
            Quizlist.Add(aQuiz);
        }
        public double CalcTotal
        {
            aTotal = 0.0;
            foreach(double aQuiz in QuizList)
        }*/

        // methods

        public double CalcTotal()
        {
            double aTotal = 0.0;

            aTotal = this.Quiz1 + this.Quiz2 + this.Quiz3 + this.Quiz4;

            return aTotal;

        }

        public double CalcAverage()
        {
            double anAverage = 0.0;

            anAverage = (this.Quiz1 + this.Quiz2 + this.Quiz3 + this.Quiz4) / 4;

            return anAverage;
        }

        public string CalcLetterGrade()
        {
            string aLetterGrade = "n/a";
            double anAverage = 0.0;

            anAverage = (this.Quiz1 + this.Quiz2 + this.Quiz3 + this.Quiz4) / 4;



            if (anAverage >= 0.0 && anAverage < 60.0)
            {
                aLetterGrade = "F";
            }
            if (anAverage >= 60.0 && anAverage < 70.0)
            {
                aLetterGrade = "D";
            }
            if (anAverage >= 70.0 && anAverage < 80.0)
            {
                aLetterGrade = "C";
            }
            if (anAverage >= 80.0 && anAverage < 90.0)
            {
                aLetterGrade = "B";
            }
            if (anAverage >= 90.0 && anAverage < 100.0)
            {
                aLetterGrade = "A";
            }



            return aLetterGrade;



        }

        
        
    }
}

