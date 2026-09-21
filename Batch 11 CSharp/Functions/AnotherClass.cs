using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Functions
{
    internal class AnotherClass
    {
        static void Main()
        {
            FunctionDemo.AddNumber(10, 2);

            NonStatic_Function obj = new NonStatic_Function();

            obj.PrintMessage();

        }
    }
}
