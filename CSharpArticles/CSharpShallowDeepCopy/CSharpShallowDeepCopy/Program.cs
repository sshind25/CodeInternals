using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShallowDeepCopy
{
    public class Department
    {
        public string DeptName { get; set; }

        public Department(string name)
        {
            DeptName = name;
        }
    }

    public class Employee
    {
        public int Id { get; set; }

        public string EmpName { get; set; }

        public Department Dept { get; set; }
        

        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        public Employee DeepCopy()
        {
            Employee emp = (Employee)this.MemberwiseClone();
            emp.Id = this.Id;
            emp.EmpName = this.EmpName;
            emp.Dept = new Department(this.Dept.DeptName);
            return emp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Shallow Copy---------------");
            Employee e1 = new Employee();
            e1.Id = 1;
            e1.EmpName = "John";
            e1.Dept = new Department("Mech");

            Employee e2 = e1.ShallowCopy();
            Console.WriteLine("Before changing");
            Console.WriteLine(string.Format("Employee e1 Id: {0}, Name: {1}, Department: {2}", e1.Id, e1.EmpName, e1.Dept.DeptName));            
            Console.WriteLine(string.Format("Employee e2 Id: {0}, Name: {1}, Department: {2}", e2.Id, e1.EmpName, e2.Dept.DeptName));
                        
            e1.Id = 2;
            e1.EmpName = "Sam";
            e1.Dept.DeptName = "E & TC";
            Console.WriteLine("After changing");
            Console.WriteLine(string.Format("Employee e1 Id: {0}, Name: {1}, Department: {2}", e1.Id, e1.EmpName, e1.Dept.DeptName));
            Console.WriteLine(string.Format("Employee e2 Id: {0}, Name: {1}, Department: {2}", e2.Id, e1.EmpName, e2.Dept.DeptName));

            Console.WriteLine("-------------------Deep Copy-------------------");            
            Employee e3 = e1.DeepCopy();
            Console.WriteLine("Before changing");
            Console.WriteLine(string.Format("Employee e1 Id: {0}, Name: {1}, Department: {2}", e1.Id, e1.EmpName, e1.Dept.DeptName));
            Console.WriteLine(string.Format("Employee e3 Id: {0}, Name: {1}, Department: {2}", e3.Id, e3.EmpName, e3.Dept.DeptName));

            e1.Id = 3;
            e1.EmpName = "Tim";
            e1.Dept.DeptName = "Computer";
            Console.WriteLine("After changing");
            Console.WriteLine(string.Format("Employee e1 Id: {0}, Name: {1}, Department: {2}", e1.Id, e1.EmpName, e1.Dept.DeptName));
            Console.WriteLine(string.Format("Employee e3 Id: {0}, Name: {1}, Department: {2}", e3.Id, e3.EmpName, e3.Dept.DeptName));

            Console.WriteLine("--------------------Equal Copy----------------------");
            Employee e4 = e1;
            Console.WriteLine("Before changing");
            Console.WriteLine(string.Format("Employee e1 Id: {0}, Name: {1}, Department: {2}", e1.Id, e1.EmpName, e1.Dept.DeptName));
            Console.WriteLine(string.Format("Employee e4 Id: {0}, Name: {1}, Department: {2}", e4.Id, e4.EmpName, e4.Dept.DeptName));

            e1.Id = 4;
            e1.EmpName = "Kim";
            e1.Dept.DeptName = "Instrumentation";
            Console.WriteLine("After changing");
            Console.WriteLine(string.Format("Employee e1 Id: {0}, Name: {1}, Department: {2}", e1.Id, e1.EmpName, e1.Dept.DeptName));
            Console.WriteLine(string.Format("Employee e4 Id: {0}, Name: {1}, Department: {2}", e4.Id, e4.EmpName, e4.Dept.DeptName));

            Console.ReadLine();
        }
    }
}
