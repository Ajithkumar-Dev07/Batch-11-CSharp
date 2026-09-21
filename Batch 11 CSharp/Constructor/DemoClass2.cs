using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Constructor
{
    internal class DemoClass2
    {
        public string Name;
        public int Age;
        public bool IsEmp;
        public double Salary;

        //parametrized Consstructor
        public DemoClass2(string name, int age, bool isemp, double salary)
        {
            Name = name;
            Age = age;
            IsEmp = isemp;
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("isEmp: "+IsEmp);
            Console.WriteLine("Salary: "+ Salary);
        }
        static void Main()
        {
            DemoClass2 obj1 = new DemoClass2("Ajith", 23, true, 40000);

            obj1.Display();

            Console.WriteLine();

            DemoClass2 obj2 = new DemoClass2("Kishore", 43, false, 5000);

            obj2.Display();

            Console.WriteLine(obj1 == obj2);
        }
    }
}
