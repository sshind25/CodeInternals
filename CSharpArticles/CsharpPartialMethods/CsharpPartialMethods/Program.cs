using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPartialMethods
{
    public sealed partial class Employee
    {
        partial void NotifyDetailsUpdate(string empName);

        public void UpdateDetails(string empName)
        {
            Console.WriteLine("Update "+ empName +" details");
            NotifyDetailsUpdate(empName);
        }
    }

    public sealed partial class Employee
    {
        partial void NotifyDetailsUpdate(string empName)
        {
            Console.WriteLine(empName + " details updated");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.UpdateDetails("Danny");

            Console.Read();
        }
    }
}
