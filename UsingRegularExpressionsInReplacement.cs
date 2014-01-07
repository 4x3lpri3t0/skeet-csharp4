using System;
using System.Text.RegularExpressions;

namespace Fundamentals.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleLine = "Hello, world!";
            Regex pattern = new Regex("[aeiou]");
            string noVowels = pattern.Replace(sampleLine, "?");
            Console.WriteLine(noVowels);
        }
    }
}
