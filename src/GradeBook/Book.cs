using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double newGrade)
        {
            grades.Add(newGrade);
        }
        public string GetAverage()
        {
            var average = 0.0;
            foreach (var grade in grades)
            {
                average += grade;
                System.Console.WriteLine(grade);
            }
            average = average / grades.Count;
            System.Console.WriteLine($"The average grade is {average:N1}.");
            return average.ToString("0.00");
        }
        public string GetHighestGrade()
        {
            var highestGrade = double.MinValue;

            foreach (var grade in grades)
            {
                highestGrade = Math.Max(grade, highestGrade);
            }

            System.Console.WriteLine($"The highest grade is {highestGrade:N1}.");
            return highestGrade.ToString("0.00");
        }

        public string GetLowestGrade()
        {
            var lowestGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                lowestGrade = Math.Min(grade, lowestGrade);
            }

            System.Console.WriteLine($"The lowest grade is {lowestGrade:N1}.");
            return lowestGrade.ToString("0.00");

        }
        public void ShowStats()
        {
            GetHighestGrade();
            GetLowestGrade();
            GetAverage();
        }
        private List<double> grades;
        private string name;

    }
}