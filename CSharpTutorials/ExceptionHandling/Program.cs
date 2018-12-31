using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try .. catch
            TryCatch();

            //try .. catch .. catch
            TryCatchCatch();

            //try .. catch .. finally
            TryCatchFinally();

            //try .. catch .. throw
            try
            {
                TryCatchThrow();
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message); // the exception message will be the one we have thrown in
                                              // in the TryCatchThrow method catch block
            }


            Console.Read();
            
        }

        private static void TryCatch()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine("Value of c" + c);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("Error: " + d.Message);
            }
        }

        private static void TryCatchCatch()
        {
            try
            {
                List<string> strList = null;
                strList.Add("John"); // this line will throw NullReferenceException 
                                     //which will be caught in last catch block because it couldn't 
                                     //find the closest matching catch type.
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("Error: " + d.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        private static void TryCatchFinally()
        {            
            using (MemoryStream memStream = new MemoryStream())
            {
                var streamWriter = new StreamWriter(memStream, UnicodeEncoding.Unicode);
                try
                {
                    streamWriter.Write("Hello");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                finally
                {
                    streamWriter.Dispose(); //this part of the code is going to execute
                                            //irrespective of exception being thrown or not
                    Console.WriteLine("StreamWriter disposed");
                }
            }
        }

        private static void TryCatchThrow()
        {
            try
            {
                List<string> strList = null;
                strList.Add("John");
            }
            catch
            {
                throw new NullReferenceException("Cannot add items to Null String List");
            }
        }
    }
}
