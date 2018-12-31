using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop
            Console.WriteLine("----------------While Loop----------------");
            int i = 5;
            while (i > 0)
            {
                Console.WriteLine("Value of i: " + i);
                i--;
            }

            //For loop
            Console.WriteLine("---------------For Loop-------------------");
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Value of j: " + j);
            }

            //do-while loop
            Console.WriteLine("---------------do-while loop------------------");
            int k = 5;
            do
            {
                Console.WriteLine("Value of k: " + k);
                k--;
            } while (k > 0);

            //nested loops
            Console.WriteLine("---------------nested loops------------------");
            for (int m = 0; m < 2; m++)
            {
                Console.WriteLine("Value of m: " + m);
                for (int n = 0; n < 5; n++)
                {
                    Console.WriteLine("Value of n: " + n);
                }
            }

            //continue statement
            Console.WriteLine("---------------continue statement------------------");
            for (int l = 0; l < 5; l++)
            {
                if (l == 3)
                    continue;
                Console.WriteLine("Value of l: " + l);
            }

            //break statement
            Console.WriteLine("---------------break statement------------------");
            for (int l = 0; l < 5; l++)
            {
                if (l == 3)
                    break;
                Console.WriteLine("Value of l: " + l);
            }

            Console.Read();
        }
    }
}
