using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAnonymousMethods
{
    class Program
    {
        internal delegate void DisplayInfo(string value);
        static void Main(string[] args)
        {
            DisplayInfo d = delegate (string value) {
                Console.WriteLine("Anonymous method value: " + value);
            };

            d("Hello!");

            Console.Read();
        }
    }
}
