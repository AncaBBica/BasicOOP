using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            gradeList = new List<double>();
            this.name = name;
        }

        public List<double> AddGrade(double grade)
        {
            if (gradeList.Count != 0)
            {
                gradeList.Add(grade);
            }
            else
            {
                gradeList = new List<double>();
                gradeList.Add(grade);
            }
            return gradeList;
        }


        public double GetAverage()
        {
            var result = 0.0;

            foreach (var number in gradeList)
            {
                result += number;
            }

            result /= gradeList.Count;

            return result;
        }

        public double HighesValue()
        {
            var highGrade = double.MinValue;
            foreach (var number in gradeList)
            {
                if (number > highGrade)
                {
                    highGrade = number;
                }
            }
            return highGrade;
        }

        List<double> gradeList;
        string name;
    }
}
