using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int a, b, c;
            double d;
            string str;

            //Variable Initialization
            a = b = c = 50;
            d = 10.05;
            str = "World";

            //Variable Declaration + Initialization
            int x = 10;
            string word = "Hello";
            int z = x + 20;

            Console.WriteLine("Integer variable: " + x);
            Console.WriteLine("String variable: " + word);
            Console.WriteLine("Initialization through an expression: " + z);
        }
    }
}
