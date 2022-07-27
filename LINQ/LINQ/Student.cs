using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CurrentClass { get; set; }
        public double ResultAverage { get; set; }

        public Student(string firstname,string surname ,string currentclass,double resultaverage)
        {
            FirstName = firstname;
            Surname = surname;
            CurrentClass = currentclass;
            ResultAverage = resultaverage;
        }
        public Student()
        {

        }
    }
}
