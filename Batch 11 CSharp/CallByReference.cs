using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    internal class CallByReference
    {
        static void ChangeValueUsingRef(ref int x)
        {
            x = 1000;

            Console.WriteLine("Inside the User defined Function x = "+x);
        }

        static void ChangeValueUsingOut(out int x)
        {
            x = 2000;

            Console.WriteLine("inside the User defined Func out x = "+x);
        }
        static void Main()
        {
            int x;

            //ChangeValueUsingRef(ref x);

            Console.WriteLine("\n");

            ChangeValueUsingOut(out x);

            Console.WriteLine("\nInside the Main Scope x = "+x);
        }
    }
}
