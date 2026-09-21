using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Functions
{
    internal class FunctionDemo
    {
        public static void PrintMesaage()
        {
            Console.WriteLine("Your Message is Printed..");
        }

        public static void AddNumber(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum = "+ sum);
        }

        static int Multiply(int num1, int num2)
        {
            int mul = num1 * num2;
            return mul;
        }


        static void Main()
        {
            PrintMesaage();
            PrintMesaage();
            PrintMesaage();
            PrintMesaage();

            Console.WriteLine("\n");

            AddNumber(10, 15);
            AddNumber(100, 200);

            Console.WriteLine("\n");

           int result =  Multiply(12, 5);

           Console.WriteLine("Result = "+ result);
        }
    }
}
