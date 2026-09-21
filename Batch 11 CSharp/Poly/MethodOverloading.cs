using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Poly
{
    internal class MethodOverloading
    {
        public void Calculator()
        {
            int x = 10;
            int y = 20;
            int sum = x + y;
            Console.WriteLine("sum = "+ sum);
        }

        public void Calculator(int x, int y)
        {
            int total = x + y;

            Console.WriteLine("Total = "+total);
        }

        public double Calculator(double x, int y)
        {
            double total = x + y;
            return total;
        }

        public double Calculator(int x, double y)
        {
            double total = x + y;
            return total;
        }

        static void Main()
        {
            MethodOverloading obj = new MethodOverloading();

            obj.Calculator();

            obj.Calculator(10, 20);

           double result1 =  obj.Calculator(12.5, 2);
           double result2 =  obj.Calculator(12, 2.0);

            Console.WriteLine("Result 1 = "+ result1);
            Console.WriteLine("Result 2 = "+ result2);
        }
    }
}
