using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Constructor
{
    internal class DemoClass3
    {
        public string Name;
        public int Age;
        public bool IsEmp;
        public double Salary;

        //parametrized Consstructor
        public DemoClass3(string name, int age, bool isemp, double salary)
        {
            Name = name;
            Age = age;
            IsEmp = isemp;
            Salary = salary;
        }

        public DemoClass3(DemoClass3 obj)
        {
            Name = obj.Name;
            Age = obj.Age;
            IsEmp = false;
            Salary = obj.Salary;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("isEmp: " + IsEmp);
            Console.WriteLine("Salary: " + Salary);
        }
        static void Main()
        {
            DemoClass3 obj = new DemoClass3("Mari", 20, true, 30000);
            obj.Display();

            Console.WriteLine(  );
            DemoClass3 obj2 = new DemoClass3(obj);

            obj2.Display();
        }
    }
}
