using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    internal class ClassFields
    {
        //Class Fields 

        public static string Name;
        public static int age;
        public static double salary;

        public static void InitailizeValue()
        {
            Name = "Praveen";
            age = 25;
            salary = 40000;
        }


        static void Main()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("Salary: " + salary);


            Console.WriteLine();
            InitailizeValue();


            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("age: "+ age);
            Console.WriteLine("Salary: "+ salary);


        }
    }

    class NewClass
    {
        static void Main()
        {
            Console.WriteLine("Name = "+ ClassFields.Name);
            Console.WriteLine("age = "+ ClassFields.age);
            Console.WriteLine("salary = "+ ClassFields.salary);
        }
    }
}
