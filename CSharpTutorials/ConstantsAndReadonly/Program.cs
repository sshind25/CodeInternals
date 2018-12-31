using System;

namespace ConstantsAndReadonly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constant value:" + ConstantDemo.number);

            ConstantDemo demo = new ConstantDemo(20);
            Console.WriteLine("Readonly value:" + demo.readonly_number);
        }
    }

    public class ConstantDemo
    {
        public const int number = 10;

        //readonly variable
        public readonly int readonly_number;

        public ConstantDemo(int param)
        {
            readonly_number = param;
        }
    }
}
