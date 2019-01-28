using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpManualResetEvent
{
    class Program
    {
        static ManualResetEvent manualResetEvent = new ManualResetEvent(false);
        
        //static EventWaitHandle manualReset = new EventWaitHandle(false, EventResetMode.ManualReset);

        static void Main(string[] args)
        {
            DoWork("Thread1");
            DoWork("Thread2");

            Console.WriteLine("Countdown for Parent thread");
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            manualResetEvent.Set();            

            Console.ReadLine();
        }

        private async static Task DoWork(string tName)
        {
            await new TaskFactory().StartNew(() =>
            {                
                manualResetEvent.WaitOne();
                Console.WriteLine("Countdown for " + tName);
                for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine(i);
                }
                manualResetEvent.Reset();               
            });
        }
    }
}
