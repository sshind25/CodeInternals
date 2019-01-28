using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAutoResetEvent
{
    class Program
    {
        static AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        //static EventWaitHandle autoReset = new EventWaitHandle(false, EventResetMode.AutoReset); 

        static void Main(string[] args)
        {
            new Thread(CountDown).Start();
            Console.WriteLine("Countdown for Parent thread");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            autoResetEvent.Set();

            Console.ReadLine();
        }

        private static void CountDown()
        {
            autoResetEvent.WaitOne();
            Console.WriteLine("Countdown for Child thread");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }            
        }
    }
}
