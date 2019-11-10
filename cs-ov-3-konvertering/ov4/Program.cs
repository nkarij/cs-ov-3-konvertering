using System;
using System.Text.RegularExpressions;

namespace ov4
{
    class Program
    {
        static void Main(string[] args)
        {
            // regex pattern, includes any word starting with upper or lowercase y/n.
            string regEx = @"\b[YyNn]\w*\b";
            System.Console.WriteLine("Is the weather nice (y/n)?");
            string input = Console.ReadLine();
            // assumes there is no match
            bool isMatch = false;

            // identifies matches to the regex
            foreach (Match match in Regex.Matches(input, regEx)) {
                
                // confirms the match
                isMatch = true;

                // to check if there is a match, Isolate first character,
                // and convert it to lowercase.
                string tempString = match.Value;
                char firstChar = tempString[0];
                string letter = firstChar.ToString().ToLower();

                if(letter == "y"){
                    System.Console.WriteLine("You should go for a picnic");
                } else if(letter == "n") {
                    Console.WriteLine("Stay home and read a programming book");
                } 
            }
            // if there is no match:
            if(!isMatch) {
                System.Console.WriteLine("I dont quite understand...?");
            }
        }
    }
}
