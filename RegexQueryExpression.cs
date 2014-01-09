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

            //var query = from line in names
            //    let match = pattern.Match(line)
            //    where match.Success
            //select new
            //{
            //    Name = match.Groups[1].Value,
            //    Relatioship = match.Groups[2]
            //};
            ////select line.ToUpper();

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            var query = from line in names
                        let match = pattern.Match(line)
                        where match.Success
                        select new
                        {
                            Name = match.Groups[1].Value,
                            Relationship = match.Groups[2].Value
                        } into association
                        group association.Name by association.Relationship;

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
