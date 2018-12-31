using System;
using System.Collections;
using System.Collections.Generic;

namespace LearnGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using existing generic class from System.Collections.Generic
            List<int> numList = new List<int>();
            numList.Add(1);
            Console.WriteLine("Item in List: " + numList[0]);

            //Using custom generic class that is created below
            GenericSample<int> obj1 = new GenericSample<int>(1);
            obj1.Display(2);

            GenericSample<string> obj2 = new GenericSample<string>("Johny");
            obj2.Display("Dhep");

            //Using a generic method which is restricetd to use only value types
            PrintValueType<int>(10);

            //Generic interface demo
            IntegerComparer comp = new IntegerComparer();
            int result = comp.Compare(1, 1);
            Console.WriteLine("Generic interface result: " + result);

            CustomGeneric cust = new CustomGeneric();
            cust.DisplayParam(20);            

            Console.Read();
        }

        //Example of Constraints
        static void PrintValueType<T>(T t1) where T : struct
        {
            Console.WriteLine("Value Type parameter: " + t1);
        }
    }    

    public class GenericSample<T>
    {
        private T tVariable;

        public T TVariable
        {
            get { return tVariable; }
            set { tVariable = value; }
        }

        public GenericSample(T t)
        {
            TVariable = t;
        }

        public void Display(T t)
        {
            Console.WriteLine("Property TVarible value: " + TVariable);
            Console.WriteLine("Parameter t value: " + t);
        }
    }

    //Implementing Generic interface with specific type parameter i.e. integer
    public class IntegerComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == y)
                return 1;
            else
                return 0;
        }
    }

    public interface ICustomGeneric<T>
    {
        void DisplayParam(T t);
    }

    public class CustomGeneric : ICustomGeneric<int>
    {
        public void DisplayParam(int t)
        {
            Console.WriteLine("Custom generic interface parameter value: " + t);
        }
    }
}
