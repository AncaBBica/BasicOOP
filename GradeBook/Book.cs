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

        List<double> gradeList;
        string name;
    }
}
