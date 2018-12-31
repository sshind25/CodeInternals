using System;
using System.Reflection;

namespace LearnReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Type example------------------");
            //Getting reference to a Type object of Employee type using System.Type.GetType()
            Type typeT = Type.GetType("LearnReflection.Employee");
            Console.WriteLine("Type.GetType() example: " + typeT.FullName);

            //Getting reference to a Type objet of Employee type using System.Object.GetType()
            Employee emp = new Employee(1, "John");
            Type typeO = emp.GetType();
            Console.WriteLine("Object.GetType() example: " + typeO.FullName);

            //Getting reference to a Type objet of Employee type using typeof operator
            Type typeOp = typeof(Employee);
            Console.WriteLine("Object.GetType() example: " + typeOp.FullName);

            Console.WriteLine("----------------GetMembers() example-----------------");
            //Now lets try to get all the members of type Employee. 
            //We'll use the typeOp object to get the members of Employee
            MemberInfo[] members = typeOp.GetMembers();
            foreach (var member in members)
            {
                Console.WriteLine(String.Format("Type of a member: {0} |  Name of member: {1}", member.MemberType, member.Name));
            }

            Console.WriteLine("----------------GetMethods() example-----------------");
            //Get all the methods of type Employee
            MethodInfo[] methods = typeOp.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(String.Format("Name of method: {0}", method.Name));
            }

            Console.WriteLine("----------------GetConstructors() example-----------------");
            //Get all the methods of type Employee
            ConstructorInfo[] constructors = typeOp.GetConstructors();
            foreach (var constructor in constructors)
            {
                Console.WriteLine(String.Format("Name of constructor: {0}", constructor.Name));
            }

            Console.WriteLine("----------------GetProperties() example-----------------");
            //Get all the methods of type Employee
            PropertyInfo[] properties = typeOp.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(String.Format("Name of property: {0}", property.Name));
            }

            Console.WriteLine("--------------GetProperty() Singular form, to get single property--------------");
            //Get a property by providing the property name
            PropertyInfo propSearch = typeOp.GetProperty("EmployeeId");
            Console.WriteLine(String.Format("Getting single property, Name of property: {0}", propSearch.Name));

            Console.Read();
        }
    }

    public class Employee
    {
        private int employeeId;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        private string employeeName;
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public Employee(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
        }

        public void PrintEmplyeeName()
        {
            Console.WriteLine("EmployeeId: " + EmployeeId);
            Console.WriteLine("EmployeeName: " + EmployeeName);
        }
    }
}
