using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    internal class SingleTon
    {
        public static SingleTon instance;

        public int id;
        public string Name;
        public double salaray;

        private SingleTon()
        {
            Console.WriteLine("Private Constructor is Called");
            id = 100;
            Name = "Vinoth";
            salaray = 30000;
        }

        public void Display()
        {
            Console.WriteLine("Id = "+id);
            Console.WriteLine("Name = "+Name);
            Console.WriteLine("Salary = "+salaray);
        }

        public static SingleTon CreateInstance()
        {
            if(instance == null)
            {
                instance = new SingleTon();

                return instance;
            }

            return instance;
        }
    }

    class Student
    {
        static void Main()
        {
           SingleTon obj1 = SingleTon.CreateInstance();

            obj1.Display();

            Console.WriteLine();
            SingleTon obj2 = SingleTon.CreateInstance();

            obj2.Display();

            Console.WriteLine(obj1 == obj2);
        }
    }
}
