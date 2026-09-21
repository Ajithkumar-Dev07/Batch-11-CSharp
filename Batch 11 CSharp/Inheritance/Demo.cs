using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Inheritance
{
    //Single Inheritance
    internal class Demo
    {
        public string Name = "Kishore";
        public int age = 25;
        public static string mesg = "Hello";
    }
    class ChildClass : Demo
    {

        static void Main()
        {
            Demo obj = new Demo();

            ChildClass obj1 = new ChildClass();

            Console.WriteLine(obj.Name);
            Console.WriteLine(obj1.age);

            Console.WriteLine("Message = "+mesg);
        }
    }
}
