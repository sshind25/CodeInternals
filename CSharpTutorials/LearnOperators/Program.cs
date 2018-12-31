using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment operators
            Console.WriteLine("--------------Assignment Operators--------------");
            int a = 5;
            int b = 10;
            Console.WriteLine("Value of a: " + a + " b: " + b);

            Console.WriteLine("Basic assignment: " + a);

            b += a;  // which is equivalent to b = b + a;
            Console.WriteLine("Addition assignment: " + b);

            b = 10;
            b -= a; // which is equivalent to b = b - a;
            Console.WriteLine("Substraction assignment: " + b);

            b = 10;
            b *= a; // which is equivalent to b = b * a;
            Console.WriteLine("Multiplication assignment: " + b);

            b = 10;
            b /= a; // which is equivalent to b = b / a;
            Console.WriteLine("Division assignment: " + b);

            b = 10;
            b %= a; // which is equivalent to b = b % a;
            Console.WriteLine("Modulo assignment: " + b);

            b = 10;
            b &= a; // which is equivalent to b = b & a;
            Console.WriteLine("Bitwise AND assignment: " + b);

            b = 10;
            b |= a; // which is equivalent to b = b | a;
            Console.WriteLine("Bitwise OR assignment: " + b);

            b = 10;
            b ^= a; // which is equivalent to b = b ^ a;
            Console.WriteLine("Bitwise XOR assignment: " + b);

            b = 10;
            b <<= a; // which is equivalent to b = b << a;
            Console.WriteLine("Left shift assignment: " + b);

            b = 10;
            b >>= a; // which is equivalent to b = b >> a;
            Console.WriteLine("Right shift assignment: " + b);

            //Relational operators
            Console.WriteLine("---------------Relational Operators---------------");
            int m = 30;
            int n = 50;
            Console.WriteLine("{0} == {1}, reuslt = {2}", m, n, (m == n));
            Console.WriteLine("{0} > {1}, reuslt = {2}", m, n, (m > n));
            Console.WriteLine("{0} < {1}, reuslt = {2}", m, n, (m < n));
            Console.WriteLine("{0} >= {1}, reuslt = {2}", m, n, (m >= n));
            Console.WriteLine("{0} <= {1}, reuslt = {2}", m, n, (m <= n));
            Console.WriteLine("{0} != {1}, reuslt = {2}", m, n, (m != n));

            //Logical operators
            Console.WriteLine("--------------Logical Operators----------------");
            int x = 10;
            int y = 20;
            if ((x > 0) && (y > 0))
            {
                Console.WriteLine("true && true = true");
            }

            if ((x > 10) || (y > 10))
            {
                Console.WriteLine("false || false = false");
            }

            //Arithmetic operators
            Console.WriteLine("--------------Arithmetic Operators----------------");
            int p = 5;
            int q = 10;
            Console.WriteLine("Addition: p + q = {0}", p + q);
            Console.WriteLine("Substraction: q - p = {0}", q - p);
            Console.WriteLine("Multiplication: p * q = {0}", p * q);
            Console.WriteLine("Division: q / p = {0}", q / p);
            Console.WriteLine("Modulus: q % p = {0}", q % p);
            Console.WriteLine("Increment: ++p = {0}", ++p);
            Console.WriteLine("Decrement: --q = {0}", --q);

            Console.Read();
        }
    }
}
