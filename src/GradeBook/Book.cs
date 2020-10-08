using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book()
        {
            grades = new List<double>();
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
            average = average/grades.Count;
            System.Console.WriteLine($"The average grade is {average:N1}.");
        }
        List<double> grades;

    }
}