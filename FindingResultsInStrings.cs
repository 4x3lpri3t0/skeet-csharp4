using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fundamentals.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "hello";

            int firstEllIndex = x.IndexOf('l');
            Console.WriteLine(firstEllIndex);
            
            int secondEllIndex = x.IndexOf('l', firstEllIndex + 1);
            Console.WriteLine(secondEllIndex);
            
            int thirdEllIndex = x.IndexOf('l', secondEllIndex + 1);
            Console.WriteLine(thirdEllIndex);

            string name = "Axel Prieto";
            int spaceIndex = name.IndexOf(' ');
            if (spaceIndex != -1)
            {
                string first = name.Substring(0, spaceIndex);
                string last = name.Substring(spaceIndex + 1);
                Console.WriteLine("First={0}; Last={1}", first, last);
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
