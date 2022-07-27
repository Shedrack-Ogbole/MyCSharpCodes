namespace practice_225
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var QuerySyntax = from obj in numbers
                              where obj > 2
                              select obj;


            foreach(var select in QuerySyntax)
            {
                Console.WriteLine(select);
            }

            Console.WriteLine("................................");

            var methodsyntax = numbers.Where(obj => obj > 2);
            foreach (var select in methodsyntax)
            {
                Console.WriteLine(select);
            }

            Console.WriteLine("................................");
            var mixedmethod = (from obj in numbers
                               select obj).Max();
            Console.WriteLine("maximum value = " + mixedmethod);
            Console.ReadLine();
        }
    }
}
