using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    internal class FunctionDemo
    {
        static (string, int) Message(string text, int num)
        {
            return (text, num);
        }

        static void Main()
        {
            var result = Message("Hello", 500);
            Console.WriteLine("Result = "+result);
            Console.WriteLine();
            Console.WriteLine("Value1 = "+ result.Item1);
            Console.WriteLine("Value2 = "+ result.Item2);
        }
    }
}
