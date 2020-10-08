using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Erica's Grade Book");
            book.AddGrade(99.1);
            book.AddGrade(56.9);
            book.AddGrade(88.3);
            book.AddGrade(65.7);

            book.GetAverage();
            book.GetHighestGrade();
            book.GetLowestGrade();
        }
    }
}
