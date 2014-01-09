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

            List<int> lengths = new List<int>() { 15, 10, 13, 14 };

            // QUERY EXPRESSION
            var query = from line in names
                        join length in lengths on line.Length equals length
                        where line.StartsWith("T")
                        select new { name = line.ToUpper(), foo = length * 2 };

            // vs

            //LAMBDA EXPRESSION
            var query2 = names.Join(lengths,
                                    line => line.Length,
                                    length => length,
                                    (line, length) => new { line, length })
                               .Where(z => z.line.StartsWith("T"))
                               .Select(z => new
                               {
                                   name = z.line.ToUpper(),
                                   foo = z.length * 2
                               });

            // The compiler translates both to the same IL
        }
    }
}
