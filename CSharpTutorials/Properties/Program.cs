using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Employee
    {
        public int empId;
        public string name;        
    }

    public class Company
    {
        private string companyName;

        public string GetCompanyName()
        {
            return companyName;
        }

        public void SetCompanyName(string value)
        {
            companyName = value;
        }
    }

    public class Department
    {
        private string deptName;
        
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }
    }

    public class IndexerDemo
    {
        private string[] countries = { "India", "USA", "Singapore", "Canada" };
        private int countriesSize = 4;

        public string this[int index]
        {
            get {
                string country = "Country not found";
                if (index >= 0 && index < countriesSize) {
                    country = countries[index];
                }
                return country;
            }
            set {
                if (index >= 0 && index < countriesSize)
                {
                    countries[index] = value;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables public
            Employee e1 = new Employee();
            e1.empId = 1;
            e1.name = "John";

            Console.WriteLine("Employee Id:" + e1.empId);
            Console.WriteLine("Employee Name:" + e1.name);

            //Using Methods to get and set the data variables
            Company c = new Company();
            c.SetCompanyName("CodeInternals");
            Console.WriteLine(c.GetCompanyName());

            //Using Properties
            Department d = new Department();
            d.DeptName = "Mechanical";

            Console.WriteLine(d.DeptName);

            //Using Indexers
            IndexerDemo id = new IndexerDemo();
            Console.WriteLine(id[0]);
            Console.WriteLine(id[3]);
            id[3] = "England";
            Console.WriteLine(id[3]);

            Console.Read();
        }
    }
}
