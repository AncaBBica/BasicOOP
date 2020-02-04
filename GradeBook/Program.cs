using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Good Omens");
            book.AddGrade(87.7);
            book.AddGrade(45.7);

            var book2 = new Book("A thousand splendid suns");
            book2.AddGrade(78.9);

            var grades = new List<double> { 12.3, 7 };
            var result = 0.0;
            var highGrade = double.MinValue;
            foreach (var number in grades)
            {
                if (number > highGrade)
                {
                    highGrade = number;
                 }

                result += number;
            }

            result /= grades.Count;

            Console.WriteLine($"the average code is {result:N1}");
            Console.ReadKey();
        }
    }
}
