using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMakingConstructs
{
    class Program
    {
        static void Main(string[] args)
        {
            //If statement
            Console.WriteLine("------------If statement---------------");
            int i = 5;
            if (i > 0)
            {
                Console.WriteLine("If block executed");
            }

            //If...Else statement
            Console.WriteLine("------------If...Else statement---------------");
            if (i < 5)
            {
                Console.WriteLine("If block executed");
            }
            else
            {
                Console.WriteLine("Else block executed");
            }

            //If...Else If...Else statement
            Console.WriteLine("------------If...Else If...Else statement---------------");
            i = 3;
            if (i == 0)
            {
                Console.WriteLine("If block executed");
            }
            else if (i == 3)
            {
                Console.WriteLine("Else If block executed");
            }
            else
            {
                Console.WriteLine("Else block executed");
            }

            //nested if statement
            Console.WriteLine("------------nested if statement---------------");
            i = 3;
            if (i > 0)
            {
                Console.WriteLine("If block executed");
                if (i == 3)
                {
                    Console.WriteLine("nested If block executed");
                }
            }

            //switch statement
            Console.WriteLine("------------switch statement---------------");
            switch (i)
            {
                case 1:
                    Console.WriteLine("Switch 1 executed");
                    break;

                case 2:
                    Console.WriteLine("Switch 2 executed");
                    break;

                case 3:
                    Console.WriteLine("Switch 3 executed");
                    break;

                default:
                    Console.WriteLine("default Switch executed");
                    break;
            }

            Console.Read();
        }
    }
}
