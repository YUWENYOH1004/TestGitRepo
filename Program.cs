// yuwenyoh ankinimbom nfi
// 01/26/2025

using System;

namespace QuizCalculator;
public class Program
{
    public static void Main(string[] args)
    {
        QuizCalculatorA aQuizCalculator = new QuizCalculatorA();

        aQuizCalculator.Quiz1 = 80.0;
        aQuizCalculator.Quiz2 = 70.0;
        aQuizCalculator.Quiz3 = 85.0;
        aQuizCalculator.Quiz4 = 87.0;

        Console.WriteLine("Total: " + aQuizCalculator.CalcTotal());
        Console.WriteLine("Average: " + aQuizCalculator.CalcAverage());
        Console.WriteLine("Grade: " + aQuizCalculator.CalcLetterGrade());
    }
}

