using System;

namespace Fundamentals.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Jon Skeet-Webb";

            // Equivalent to x.Split(new char[] { ' ', '-', '|' });
            string[] words = x.Split(' ', '-', '|');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
