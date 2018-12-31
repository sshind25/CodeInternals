using System;
using System.Reflection;

namespace LearnAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.StudentName = "John";
            stud.StudentAge = 5;
            stud.ValidateAge();

            stud.StudentAge = 15;
            stud.ValidateAge();

            Console.Read();
        }
    }

    public class Student
    {
        public string StudentName { get; set; }

        [RangeValidator(10, 20)]
        public int StudentAge { get; set; }

        //We'll make use of information provided in the RangeValidatorAttribute to validate the age of student
        //And we are using reflection to get the attributes information
        public void ValidateAge()
        {
            Type type = this.GetType();
            PropertyInfo property = type.GetProperty("StudentAge");
            RangeValidatorAttribute attrib = (RangeValidatorAttribute)property.GetCustomAttribute(typeof(RangeValidatorAttribute));
            if (StudentAge >= attrib.MinValue && StudentAge <= attrib.MaxValue)
            {
                Console.WriteLine(String.Format("{0} age is within range", StudentName));
            }
            else
            {
                Console.WriteLine(String.Format("{0} age is out of range. Expected is within 10 to 20.", StudentName));
            }
        }
    }

    //Custom attribute to add information about the range on a property
    [AttributeUsage(AttributeTargets.Property)]
    public class RangeValidatorAttribute : Attribute
    {
        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        public RangeValidatorAttribute(int minValue, int maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }
    }
    
}
