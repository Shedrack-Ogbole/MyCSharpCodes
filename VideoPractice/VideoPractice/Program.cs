using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace VideoPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\C:\Users\Student\source\";
            string[] dir = Directory.GetDirectories(rootpath,"*",SearchOption.TopDirectoryOnly);
            foreach(string item in dir)
            {
                Console.WriteLine(item);
            }

        }
    }
}
