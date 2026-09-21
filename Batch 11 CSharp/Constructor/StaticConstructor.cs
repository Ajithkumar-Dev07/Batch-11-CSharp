using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Constructor
{
    internal class StaticConstructor
    {
        static int id;
        static string name;
        static double salary;

        static StaticConstructor()
        {
            Console.WriteLine("static Constrcutor is Callled");
            id = 100;
            name = "Ganesh";
            salary = 30000;
        }

        public StaticConstructor()
        {
            Console.WriteLine("Default Constructor is Called");

            id = 102;
            name = "Vinoth";
            salary = 29000;
        }

        public void Display()
        {
            Console.WriteLine("Id = "+id);
            Console.WriteLine("Name = "+name);
            Console.WriteLine("Salary = "+salary);
        }

        static void Main()
        {
            StaticConstructor obj = new StaticConstructor();

            obj.Display();
           
        }
    }
}
