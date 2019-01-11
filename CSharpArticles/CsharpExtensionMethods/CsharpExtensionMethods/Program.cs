using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpExtensionMethods;

namespace CsharpExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extension method usage
            string name = "Johny Brown";
            Console.WriteLine(name.Prefix("Mr.").Suffix(", Hello!"));  // Prints Mr.Johny Brown, Hello!
            
            Console.Read();
        }
    }
}
