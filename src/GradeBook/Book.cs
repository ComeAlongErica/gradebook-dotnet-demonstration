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
            foreach (var grade in grades)
            {
                System.Console.WriteLine(grade);
            }
        }
        List<double> grades;

    }
}