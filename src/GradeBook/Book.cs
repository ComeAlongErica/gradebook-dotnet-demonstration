using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
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
        public void GetAverage()
        {
            var average = 0.0;
            foreach (var grade in grades)
            {
                average += grade;
                System.Console.WriteLine(grade);
            }
            average = average / grades.Count;
            System.Console.WriteLine($"The average grade is {average:N1}.");
        }
        public void GetHighestGrade()
        {
            var highestGrade = double.MinValue;

            foreach (var grade in grades)
            {
                highestGrade = Math.Max(grade, highestGrade);
            }

            System.Console.WriteLine($"The highest grade is {highestGrade:N1}.");
        }

        public void GetLowestGrade()
        {
            var lowestGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                lowestGrade = Math.Min(grade, lowestGrade);
            }

            System.Console.WriteLine($"The lowest grade is {lowestGrade:N1}.");
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