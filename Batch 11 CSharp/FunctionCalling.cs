using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    internal class FunctionCalling
    {
        static void StaticFun1() //Static Function
        {
            Console.WriteLine("Static Function 1 is executed");
        }

        void NonStaticFun1() //Non Static Function
        {
            Console.WriteLine("Non Static Function is Executed");
            StaticFun1();
            NonStaticFun2();
        }

        void NonStaticFun2()
        {
            Console.WriteLine("Non static Fun 2 is Excuted");
            
        }

        static void StaticFun2()
        {
          //  NonStaticFun2();
        }
        static void Main()
        {
            StaticFun1();

            FunctionCalling call = new FunctionCalling();

            call.NonStaticFun1();
        }
    }
}
