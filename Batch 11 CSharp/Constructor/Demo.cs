using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Constructor
{
    internal class Demo
    {
        string Name;
        int age;
        double salary;
        bool isEmp;

        //Default Constructor
        public Demo()
        {
            Console.WriteLine("Default Constructor is Called");
            Name = "Jhon";
            age = 28;
            salary = 45000;
            isEmp = true;
        }



        public void DisplayDetails()
        {
            Console.WriteLine("Name = "+Name);
            Console.WriteLine("Age = "+age);
            Console.WriteLine("salary = "+salary);
            Console.WriteLine("Is Employee = "+ isEmp);
        }
        static void Main()
        {
            Demo obj = new Demo(); //Calling an Implicit Constructor

            obj.DisplayDetails();

            Console.WriteLine();

            Demo obj2 = new Demo();

            obj2.DisplayDetails();


        }
    }
}
