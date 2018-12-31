using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class DemoConstructor
    {
        private static int j;
        private int i;
        //Instance Constructor
        public DemoConstructor()
        {
            i = 10;
        }

        //Static constructor
        static DemoConstructor()
        {
            j = 20;
        }

        //Method definition
        public void DisplayValue()
        {
            Console.WriteLine(i);
        }

        //static method
        public static void DisplayStaticValue()
        {
            Console.WriteLine(j);
        }
    }

    public class DemoMethods
    {
        public int AddNumbers(int num1, int num2)
        {
            int result;
            result = num1 + num2;
            return result;
        }

        //Passing parameters by value example
        public void ParamByValueDemo(int num)
        {
            num = 20;
        }

        //Passing parameters by reference example
        public void ParamByReferenceDemo(ref int num)
        {
            num = 20;
        }
    }

    #region Demo Polymorphism

    public class PolyBase
    {
        #region Method Overloading

        public void DisplayValue(string value)
        {
            Console.WriteLine(value);
        }

        public void DisplayValue(string value1, string value2)
        {
            Console.WriteLine(value1 + " " + value2);
        }

        public void DisplayValue(int value)
        {
            Console.WriteLine(value);
        }

        #endregion

        #region Method Overriding

        public virtual void GreetUser(string username)
        {
            Console.WriteLine("Hi " + username);
        }

        #endregion
    }

    public class PolyDerived : PolyBase
    {
        #region Overriden Method
        public override void GreetUser(string username)
        {
            Console.WriteLine("Hello " + username);
        }
        #endregion
    }

    #endregion

    #region Operator Overloading

    public class DemoOperatorOverload
    {
        private int num;
        public DemoOperatorOverload(int value)
        {
            num = value;
        }

        public int GetNum()
        {
            return num;
        }

        public static DemoOperatorOverload operator +(DemoOperatorOverload obj1, DemoOperatorOverload obj2)
        {            
            int addesResult = obj1.GetNum() + obj2.GetNum();
            DemoOperatorOverload obj = new DemoOperatorOverload(addesResult);
            return obj;
        }
    }

    #endregion

    class Program
    {
        

        static void Main(string[] args)
        {
            //Instance constructor 
            DemoConstructor demoConstructor = new DemoConstructor();
            demoConstructor.DisplayValue();

            //Static constructor
            DemoConstructor.DisplayStaticValue();
                        
            DemoMethods method = new DemoMethods();
            //Parameterized methods
            int c = method.AddNumbers(10, 20);
            Console.WriteLine(c);

            //Passing parameters by value
            int num = 10;
            Console.WriteLine(num); //Prints 10
            method.ParamByValueDemo(num);
            Console.WriteLine(num); //Prints 10    

            //Passing parameters by reference
            int num1 = 10;
            Console.WriteLine(num1); //Prints 10
            method.ParamByReferenceDemo(ref num1);
            Console.WriteLine(num1); //Prints 20     

            //Method Overloading
            PolyBase p = new PolyBase();
            p.DisplayValue("Hello");  //Prints Hello
            p.DisplayValue("Hello", "World");  //Prints Hello World
            p.DisplayValue(10); //Prints 10

            //Method Overriding
            PolyDerived d = new PolyDerived();
            d.GreetUser("Rock"); //Prints Hello Rock

            PolyBase pb = new PolyDerived();
            d.GreetUser("John"); //Prints Hello John

            PolyBase b = new PolyBase(); //Prints Hi RockBase
            b.GreetUser("RockBase");

            //Operator Overloading
            DemoOperatorOverload d1 = new DemoOperatorOverload(20);
            DemoOperatorOverload d2 = new DemoOperatorOverload(30);
            DemoOperatorOverload d3 = d1 + d2;
            Console.WriteLine("Operator overloaded result: " + d3.GetNum());


            Console.Read();
        }
    }
}
