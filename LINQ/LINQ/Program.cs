using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>() { "john", "hassan", "godwin" };



            //List<Student> Students = new List<Student>()
            //{
            //    new Student("Joy","Agada","jss 3",67.9),
            //    new Student("Naomi","Isaac","jss 1",56.2),
            //    new Student("Samuel","Onoja","ss 1",87.9),
            //    new Student("Gloria","Agbu","jss 1",69.1),
            //    new Student("David","Bright","ss 3",77.6),
            //    new Student("Isaac","Hassan","jss 1",39.9),
            //    new Student("Jeremaih","Owoich","jss 3",39.9),
            //};

            //var ms = Students.OrderByDescending(emp => emp.FirstName).ThenByDescending(emp => emp.Surname).ToList();


            //var querysytax = from emp in Students
            //                 orderby emp.FirstName ascending
            //                 select emp;

            foreach (var contain in names)
            {
               Console.WriteLine(contain);
                //Console.WriteLine($"{contain.FirstName} {contain.Surname} {contain.CurrentClass} {contain.ResultAverage}");
            }

            Console.WriteLine("........................................");

            names.Reverse();

            foreach(var item in names)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

          //using the query syntax
            //var Querysyntax = from obj in Students
            //                  where obj.CurrentClass == "jss 1"
            //                  select obj;

            //var selectquery = (from stu in Students
            //                   select stu).ToList();

            //foreach (var contain in selectquery)
            //{
            //    Console.WriteLine($"{contain.FirstName} {contain.Surname} {contain.CurrentClass} {contain.ResultAverage}");
            //}

            //Console.WriteLine(".........................................");

            //var selectmanyquery = Students.SelectMany(x => x.FirstName).ToList();






            //var selectmethod = Students.Select(stu => stu).ToList();


            //foreach (var contain in selectmethod)
            //{
            //    Console.WriteLine($"{contain.FirstName} {contain.Surname} {contain.CurrentClass} {contain.ResultAverage}");
            //}

            //using the method syntax

            //var methodsyntax = Students.Where(obj => obj.CurrentClass == "jss 1" && obj.ResultAverage >= 50);
            //foreach (var contain in methodsyntax)
            //{
            //    Console.WriteLine($"{contain.FirstName} {contain.Surname} {contain.CurrentClass} {contain.ResultAverage}");
            //}

            //Console.WriteLine("................................");

            //var mixedmethod = (from obj in Students
            //                   select obj.ResultAverage).Max();

            //Console.WriteLine("Max Average is = " + mixedmethod);

        }
    }
}