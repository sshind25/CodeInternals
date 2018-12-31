using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single dimensional array
            int[] numArray = new int[5];
            //System.Array provides a method SetValue() to set the value of an array at specified index
            numArray.SetValue(1, 0);
            //Alternatively, you can also set the value like below
            numArray[1] = 2;
            numArray[2] = 3;
            numArray[3] = 4;
            numArray[4] = 5;

            Console.WriteLine("***************Single dimensional array******************");
            Console.WriteLine(numArray.GetValue(0));
            Console.WriteLine(numArray[1]);
            Console.WriteLine(numArray[2]);
            Console.WriteLine(numArray[3]);
            Console.WriteLine(numArray[4]);

            //Multi-dimensional Array
            int[,] table = new int[2, 2];
            table[0, 0] = 1;
            table[0, 1] = 2;
            table[1, 0] = 3;
            table[1, 1] = 4;

            Console.WriteLine("***************Multi-dimensional array******************");
            Console.WriteLine(String.Format("{0} | {1}", table[0, 0], table[0, 1]));            
            Console.WriteLine("-----");
            Console.WriteLine(String.Format("{0} | {1}", table[1, 0], table[1, 1]));

            //Jagged Arrays
            int[][] jagged = new int[1][];
            jagged[0] = new int[2];

            jagged[0][0] = 1;
            jagged[0][1] = 2;

            Console.WriteLine("***************Jagged array******************");
            Console.WriteLine(String.Format("{0} | {1}", jagged[0][0], jagged[0][1]));

            Console.Read();
        }
    }
}
