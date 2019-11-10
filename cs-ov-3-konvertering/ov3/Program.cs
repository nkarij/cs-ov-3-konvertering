using System;

namespace ov3
{
    class Program
    {
        static void Main(string[] args)
        {
            // username input
            // welcome to user
            // user age input
            // math: how many days the user have lived. skudår?
            // result: math;
            
            Console.WriteLine("Type your name:");
            string nameInput = Console.ReadLine();
            Console.WriteLine($"Welcome {nameInput}");
            Console.WriteLine("write your age");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            int result = 365 * age;
            Console.WriteLine(result);
        }
    }
}
