using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 20.03, 20.03, 20.03 };
            grades.Add(88.2);
            var result = 0.0;

            foreach(double number in grades) 
            {
                result += number;
            }
            System.Console.WriteLine(result/grades.Count);
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
