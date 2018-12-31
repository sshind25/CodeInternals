using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empty string initialization
            string emptyString = String.Empty;

            //Null string initialization
            string nullString = null;

            //Initialize string with a valid string
            string str = "Hello";

            //Using String object
            String str2 = "World";

            //Initializing String object with an array of Char object
            Char[] characters = { 'H', 'W' };
            String strObj = new String(characters);

            //Regular string literal with backslash escape sequence
            string regStr = "c:\\users\\abc";

            //Verbatim string literal
            string verStr = @"c:\users\abc";

            //Using string builder to manipulate string
            StringBuilder builder = new StringBuilder("Hello");
            Console.WriteLine(builder.ToString());

            builder.AppendLine(" World");
            Console.WriteLine(builder.ToString());

            //If i had to do the similar thing as above using string it would have been something like below
            string hello = "Hello";
            Console.WriteLine(hello);

            string hworld = hello + " World";
            Console.WriteLine(hworld);

            Console.Read();
        }
    }
}
