using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    /// Interface definition
    /// </summary>
    public interface IDisplayInfo
    {
        string Name { get; set; }
        void Display();
    }

    /// <summary>
    /// Defining another interface to show multiple inheritance
    /// </summary>
    public interface ILogInfo
    {
        void LogInfo();
    }

    /// <summary>
    /// Interface with same method name as contained in IDisplayInfo
    /// </summary>
    public interface IConsoleInfo
    {
        void Display();
    }

    /// <summary>
    /// Non-generic interface
    /// </summary>
    public interface ICalculation
    {
        void AddObject(object obj1, object obj2);
    }

    /// <summary>
    /// Generic interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICalculation<T>
    {
        void Add(T t1, T t2);
    }

    public class ConsoleApp : IDisplayInfo, ILogInfo, IConsoleInfo
    {
        #region IDisplayInfo members
        public string Name { get; set; }

        void IDisplayInfo.Display()
        {
            Console.WriteLine("Display Info");
        }
        #endregion

        #region IConsoleApp members

        void IConsoleInfo.Display()
        {
            Console.WriteLine("Console Info");
        }

        #endregion

        #region ILogInfo members
        public void LogInfo()
        {
            Console.WriteLine("Log Info");
        }
        #endregion
    }

    /// <summary>
    /// Class implementing both non-generic and generic interfaces
    /// </summary>
    public class Calculator : ICalculation, ICalculation<int>, ICalculation<string>
    {
        #region non-generic
        public void AddObject(object obj1, object obj2)
        {
            Console.WriteLine((int)obj1 + (int)obj2);
        }
        #endregion

        #region generic
        public void Add(int t1, int t2)
        {
            Console.WriteLine(t1 + t2);
        }

        public void Add(string t1, string t2)
        {
            Console.WriteLine(t1 + t2);
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleApp app = new ConsoleApp();            
            app.LogInfo();

            IConsoleInfo consoleInfo = app;
            consoleInfo.Display();

            IDisplayInfo displayInfo = app;
            displayInfo.Display();

            //Generic interface usage
            Calculator calc = new Calculator();
            calc.AddObject(10, 5); //Integer values 10 and 5 are boxed into an object when passed. It will print 15 
            calc.Add(10, 5); //It will call generic method with integer parameters and print 15.
            calc.Add("Hello", "World"); //It will call generic method with string parameters and print HelloWorld 

            //Passing strings to AddObject method will still compile, 
            //but it will throw an InvalidCastException at runtime
            calc.AddObject("Hello", "World");

            Console.Read();
        }
    }
}
