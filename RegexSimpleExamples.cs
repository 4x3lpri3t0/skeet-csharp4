using System;
using System.Text.RegularExpressions;

namespace Fundamentals.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex pattern = new Regex(" ");
            //string text = "Jon Skeet";
            //string[] words = pattern.Split(text);
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}

            string patternText = @"\d"; // \d = digit ... using verbatim (@) to use just one '\'
            Console.WriteLine(patternText);
            Regex pattern = new Regex(patternText);

            string text = "Jon0Skeet1Rob2Conery";
            string[] words = pattern.Split(text);
            
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
