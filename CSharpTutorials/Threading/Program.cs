using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic threading example
            Console.WriteLine("Main Thread");
            Thread t1 = new Thread(PrintNumbers1To10);
            Thread t2 = new Thread(PrintNumbers11To20);
            t1.Start();
            t2.Start();

            //Thread Synchronization: Lock example
            for (int i = 0; i < 100; i++)
            {
                Thread t3 = new Thread(() => ReadWriteValue(i));
                t3.Start();
            }

            Console.ReadLine();
        }

        private static void ReadWriteValue(int x)
        {
            LockDemo d = new LockDemo();
            d.WriteValue(x);
            Console.WriteLine(d.ReadValue());
        }

        private static void PrintNumbers1To10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Thread1:" + i);
            }
        }

        private static void PrintNumbers11To20()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine("Thread2:" + i);
            }
        }
    }

    public class LockDemo
    {
        private object lockObj = new object();
        private int value = 10;

        //No need of lock here, because we're just reading a value 
        public int ReadValue()
        {
            return value;
        }

        //locking it, because multiple writes by multiple threads 
        //at same time could corupt the data 
        public void WriteValue(int x)
        {
            lock (lockObj)
            {
                value = x;
            }
        }
    }
}
