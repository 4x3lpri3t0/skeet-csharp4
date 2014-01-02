using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasteringCSharp_OptionalParameters
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Foo("Rob");
        //    Foo("Jon");
        //    Foo("Eric");
        //    Foo("hi", "man");
        //}

        //static void Foo(string x)
        //{
        //    Console.WriteLine("Hello " + x);
        //}

        //static void Foo(string x, string y)
        //{
        //    Console.WriteLine(x + " " + y);
        //}

        static void Main(string[] args)
        {
            Foo(y: "Rob");
            Foo(y: "Jon");
            Foo(y: "Eric");
            Foo(x: "Ahoy", y: "sailor");
            Foo("Hi", "Axel");
            Foo();
        }

        static void Foo(string x = "Hello", string y = "dude")
        {
            Console.WriteLine(x + " " + y);
        }

        // Optional Parameters provide default values for arguments
        // Instead of overloading methods, we can use Optional Parameters
    }
}
