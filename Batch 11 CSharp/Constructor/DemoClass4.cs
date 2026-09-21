using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Constructor
{
    internal class DemoClass4
    {

        private DemoClass4()
        {
            Console.WriteLine("Private Constructor is Called");
        }

        static void Main()
        {
            DemoClass4 obj = new DemoClass4();


        }
    }

    class DemoClass5
    {
        static void Main()
        {
            //DemoClass4 obj = new DemoClass4();


        }
    }
}
