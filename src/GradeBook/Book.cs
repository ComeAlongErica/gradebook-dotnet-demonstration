using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
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
            return average.ToString("0.00");
        }
        public string GetHighestGrade()
        {
            var highestGrade = double.MinValue;

            foreach (var grade in grades)
            {
                highestGrade = Math.Max(grade, highestGrade);
            }

            return highestGrade.ToString("0.00");
        }

        public string GetLowestGrade()
        {
            var lowestGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                lowestGrade = Math.Min(grade, lowestGrade);
            }

            return lowestGrade.ToString("0.00");

        }
        public Statistics GetStats()
        {
            var result = new Statistics();
            result.High = GetHighestGrade();
            result.Low = GetLowestGrade();
            result.Average = GetAverage();

            return result;
        }
        private List<double> grades;
        public string Name;

    }
}