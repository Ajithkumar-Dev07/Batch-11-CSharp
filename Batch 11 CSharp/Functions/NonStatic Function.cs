using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Functions
{
    internal class NonStatic_Function
    {
        public void PrintMessage()
        {
            Console.WriteLine("Non static function is executed...");
        }

        int Total(int x, int y)
        {
            int total = x + y;

            return total;
        }
        static void Main()
        {
            NonStatic_Function obj = new NonStatic_Function(); //Object

            obj.PrintMessage();

            int result = obj.Total(20, 10);
            Console.WriteLine("Result = "+result);
        }
    }
}
