using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread start");
            ThreadPool.QueueUserWorkItem(PrintNumbers);

            //Main thread performing its own number counting task
            for (int j = 11; j <= 20; j++)
            {
                Console.WriteLine("Main Thread (value of j):" + j);
            }

            Console.WriteLine("Main thread end");

            Console.ReadLine();
        }

        //This task will run on a background thread in a ThreadPool
        private static void PrintNumbers(object state)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("ThreadPool thread (value of i):" + i);
            }
        }
    }
}
