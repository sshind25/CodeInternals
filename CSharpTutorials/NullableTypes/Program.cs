using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {   
            Nullable<int> nullable = 10;
            PrintNullableValue(nullable);
            nullable = null;
            PrintNullableValue(nullable);

            int? improvized = 20;
            PrintNullableValue(improvized);
            improvized = null;
            PrintNullableValue(improvized);

            
            int? c = 30;
            //Unary Conditional Operator expression
            int d = c.HasValue ? c.Value : 0;
            Console.WriteLine("d value: " + d);

            //Null-coalescing operator expression
            c = 40;
            d = c ?? 0;
            Console.WriteLine("d value: " + d);

            Console.Read();
        }

        private static void PrintNullableValue(Nullable<int> param)
        {
            if (param.HasValue)
                Console.WriteLine(" Value: " + param.Value);
            else
                Console.WriteLine(" Value: null");
        }
    }
}
