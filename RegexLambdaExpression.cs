using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Rob, Friend",
                "Holly, Family",
                "This isn't a name",
                "NOT$#()/!A#NAME",
                "Malcolm, Colleague",
                "Tom, Family",
                "Jose, Family"
            };

            Regex pattern = new Regex("([^,]*), (.*)");

            // LAMBDA EXPRESSIONS
            var query = names.Select(line => new {line, match = pattern.Match(line)})
                .Where(z => z.match.Success)
                .Select(z => new
                {
                    Name = z.match.Groups[1].Value,
                    Relationship = z.match.Groups[2].Value
                })
                .GroupBy(association => association.Relationship,
                    association => association.Name);

            foreach (var group in query)
            {
                Console.WriteLine("Relationship: {0}", group.Key);
                foreach (var name in group)
                {
                    Console.WriteLine("  {0}", name);
                }
            }
        }
    }
}
