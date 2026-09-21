using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Poly
{
    class ClassA
    {
        public virtual void Displaymessage(string message)
        {
            Console.WriteLine("message = " + message);
        }
    }
    class ClassB : ClassA
    {
        public override void Displaymessage(string message)
        {
            Console.WriteLine("message = "+ message);

            base.Displaymessage("Calling from ClassB");
        }
    }
    internal class MethodOverriding
    {
        static void Main()
        {
            ClassB objb = new ClassB();

            objb.Displaymessage("Hello");

            Console.WriteLine();

            ClassA obj = new ClassB();

            obj.Displaymessage("Calling Function");
        }
    }
}
