using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            gradeList = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
          gradeList.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            

            foreach (var grade in gradeList)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= gradeList.Count;

            return result;
        }

        

        List<double> gradeList;
        string name;
    }
}
