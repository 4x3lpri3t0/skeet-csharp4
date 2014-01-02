using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasteringCSharp_BasicsOfSystem.Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //object x = "hello";
            //string y = (string) x;
             
            //Console.WriteLine(((string) x).Length); //5
            //Console.WriteLine(y.Length); //5

            //dynamic x = "hello";
            //Console.WriteLine(x.Length); //5
            //x = new int[] { 10, 20, 30 };
            //Console.WriteLine(x.Length); //3

            //int x = 123;
            //int y = 10;
            dynamic x = 123;
            dynamic y = 10;
            Console.WriteLine(x - 10);
            // Here Jon shows the difference between CLR and DLR (Dynamic) -> a library that resolves dynamic types usage.
            // Using ILDASM (decompiler/disassembler) we can see how DLR works
        }
    }
}
