using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqOperators_Select_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Shedrack", Email = "ogboleshedrack2@gmail.com" },
                new Employee(){ Id = 2, Name = "Onyilokwu", Email = "ogboleonyilokwu5@gmail.com"},
                new Employee(){ Id = 3, Name = "Ekwu", Email = "ekwujohnson42@gmail.com"}
            };

            //how to select data using an index

            var query = employees.SelectMany(x => x.Name).ToList();
            var queryresult = (from rec in employees
                               from ch in rec
                               select ch).ToList();
                              



            //foreach (var item in query)
            //{
            //    Console.WriteLine($" Id = {item.StudentId } Name = {item.fullName} Emain = { item.StudentEmail}");
            //}

           

            //Console.ReadLine();
        }
    }
}
