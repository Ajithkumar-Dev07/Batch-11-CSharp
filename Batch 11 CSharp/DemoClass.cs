using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    internal class DemoClass
    {
        string Message; //Instance variable

        public void InitializeValue(string message)
        {
            Message = message;
        }
        static void Main()
        {
            DemoClass obj1;

            obj1 = new DemoClass(); //Instance class, created by new keyword

            obj1.InitializeValue("Hello");
            Console.WriteLine(obj1.Message);


            DemoClass obj2;

            obj2 = obj1; //Reference of a class


            obj2.Message = "C# Programming";

            Console.WriteLine( );

            Console.WriteLine("obj2 = "+obj2.Message);
            Console.WriteLine("obj1 = "+obj1.Message);

        }
    }
}
