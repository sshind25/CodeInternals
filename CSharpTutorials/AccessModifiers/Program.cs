using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessSample sam = new AccessSample();
            //prop3 in AccessSample is a public member. 
            //Hence, it is accessible everywhere 
            //and prop1 and prop2 being private and protected respectively are not accessible.
            Console.WriteLine(sam.prop3);

            //This method is accessible only within the assembly 'AccessModifiers'
            sam.PrintProp1AndProp2();

            AccessDerived derived = new AccessDerived();
            derived.PrintProp2();
            derived.PrintProp4();
        }
    }

    //This class is accessible everywhere. No restritions
    public class AccessSample
    {
        private int prop1 = 10;
        protected string prop2 = "Hello";
        public bool prop3 = true;
        protected internal int prop4 = 100;

        internal void PrintProp1AndProp2()
        {
            //prop1 is accessible only within the class
            //prop2 is accessible within the class and type derived from AccessSample class
            Console.WriteLine(prop1 + " " + prop2);
        }
    }

    //This class is accessible only within the assembly
    internal class AccessDerived : AccessSample
    {
        public void PrintProp2()
        {
            //prop2 is accessible within type derived from AccessSample class
            Console.WriteLine(prop2);
        }

        //PrintProp4 is accessible only in current assembly
        internal void PrintProp4()
        {
            //prop4 is accessible in current assembly and type derived from containing class
            Console.WriteLine(prop4);
        }
    }
}
