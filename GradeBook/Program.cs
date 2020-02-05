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

            
            while (true)
            {
                Console.WriteLine("Enter a grade or q to quit: ");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            } 


            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest value is {stats.Low}");
            Console.WriteLine($"The highest value is {stats.High}");
            Console.WriteLine($"The average value is {stats.Average:N1}");

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
