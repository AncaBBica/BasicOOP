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

            var result = book.GetAverage();

            Console.WriteLine($"the average code is {result:N2}");

            string name = "Anca";
            var date = DateTime.Now;

            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

            Console.ReadKey();
        }
    }
}
