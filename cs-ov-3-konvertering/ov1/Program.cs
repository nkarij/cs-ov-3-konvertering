using System;

namespace ov1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            
            Console.WriteLine("skriv et tal!");
            string inputOne = Console.ReadLine();
            int resultOne = Convert.ToInt32(inputOne);

            Console.WriteLine("skriv et tal mere!");
            string inputTwo = Console.ReadLine();
            int resultTwo = Convert.ToInt32(inputTwo);

            var result = resultOne + resultTwo;

            Console.WriteLine($"Summen er: {result}");

        }
    }
}
