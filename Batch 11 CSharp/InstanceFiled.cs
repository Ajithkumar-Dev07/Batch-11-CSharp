using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    internal class InstanceFiled
    {
        string Name;
        int age;
        double salary;

        public void DisplayFields()
        {

            Console.WriteLine("Name = "+ Name);
            Console.WriteLine("age = "+ age);
            Console.WriteLine("salary = "+ salary);
        }

        static void Main()
        {
            InstanceFiled obj1 = new InstanceFiled();

            obj1.Name = "Barath";
            obj1.age = 30;
            obj1.salary = 45000;

            obj1.DisplayFields();
            Console.WriteLine();

            obj1.DisplayFields();

            Console.WriteLine("\nCreating an new Object");

            InstanceFiled obj2 = new InstanceFiled();
            obj2.age = 25;

            obj2.DisplayFields();
        }
    }
}
