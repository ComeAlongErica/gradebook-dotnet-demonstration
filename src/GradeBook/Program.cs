using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(99.1);
            book.AddGrade(56.9);
            book.AddGrade(88);

            book.GetAverage();
        }
    }
}
