using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    internal class CallByValue
    {
        static void CallingValue(int x)
        {
            x = 1000; //Change to 1000

            Console.WriteLine("Inside the user defined Function: "+x);
        }
        static void Main()
        {
            int x = 10;

            CallingValue(x);  //Copy of the values is been sent to the function not the orginal value

            Console.WriteLine("Inside the main method x = "+x);
        }
    }
}
