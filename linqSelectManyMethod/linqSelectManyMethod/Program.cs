using System;
using System.Collections.Generic;
using System.Linq;



namespace linqSelectManyMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Student> students = new List<Student>()
            //{
            //    new Student(1,"Adams"),
            //     new Student(1,"shedrack"),
            //      new Student(1,"Adams"),
            //       new Student(1,"shedrack"),
            //};

            //var mes = students.Select(x => x.Name).Distinct().ToList();

            
           
            List<string> numbers = new List<string>() { "2", "3", "2", "1","4"};
            List<string> numbers1 = new List<string>() { "1", "2", "3","5" };

    

             var ms = numbers.Union(numbers1).ToList();



            //var ms = numbers.Distinct().ToList();

            //var qs = (from num in numbers
            //          select num).Distinct().ToList();


            Console.ReadLine();

        }

    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id,string name)
        {
            Id = id;
            Name = name;
        }
    }
}
