using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqAssignment
{
    class Program
    {

        /*                                          ATTEMPT !!!
         *                                          
         1.//FAILED


        2.a select and
        b. SelectMany CORRECT
        */


        // 

        static void Main(string[] args)
        {
            // Answer to 3a
            List<StudentRecord> studentData = new List<StudentRecord>()
            {
                new StudentRecord(2,"Shedrack","Ogbole"),
                new StudentRecord(1,"Grace","Adams"),
                new StudentRecord(3,"Gloria","Oguche")
            };//CORRECT BUT HALF MARK, LIST NOT COMPLETE

            // Answer to 3b

            var MethodSyntax = studentData.OfType<int>().ToList();//HALF MARK

            // Answer to 3c




            // Answer to 4

            //sorting operators are used to manage data from a source in a particular order CORRECT
            /*Types of sorting operators*/
            // a. OrderBy
            // b. OrderByDescending
            // C. ThenBy
            // d. ThenByDescending
            // CORRECT

            //Answer to 5

           

            List<int> Numbers = new List<int>() { 5, 8, 7, 4,  6, 2, 3,1 };

            var Ms = Numbers.OrderBy(emp => emp).ToList();//CORRECT
            foreach (var item in Ms)
            {
                Console.WriteLine(item);
            }


            //Descending order of list

            var DescendingMethod = Numbers.OrderByDescending(gh => gh).ToList();//CORRECT

            foreach (var num in Numbers)
            {
                Console.WriteLine(num);
            }


            //Answer to 6 

            var ThenByMethod = Numbers.OrderBy(emp => emp).ThenByDescending(emp => emp).ToList();//FAIL


           // Answer to 7

            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var ReverseMethodSyntax = Num.Reverse();//CORRECT

            foreach(var obj in ReverseMethodSyntax)
            {
                Console.WriteLine(obj);
            }


            Console.ReadLine();
        }
    }
}
