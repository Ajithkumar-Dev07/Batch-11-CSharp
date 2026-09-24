using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.String_and_StringBuilder
{
    internal class StringBuilderDemo
    {
        static void Main()
        {
            StringBuilder sb1 = new StringBuilder("Hello");

            Console.WriteLine(sb1+"  "+ sb1.GetType());

            //sb1.Append(" World");

            Console.WriteLine(sb1);

            StringBuilder sb2 = new StringBuilder("Hello");

            Console.WriteLine(sb1 == sb2);


            Console.WriteLine("\n ");

            StringBuilder Text1 = new StringBuilder("Program");

            StringBuilder Text2 = Text1;

            Console.WriteLine("Text1 = "+Text1);
            Console.WriteLine("Text2 = "+Text2);

            Text2.Replace("Program", "Language");

            Console.WriteLine();

            Console.WriteLine("Text1 = " + Text1);
            Console.WriteLine("Text2 = " + Text2);

            Console.WriteLine("Is both are equal = "+Text1.Equals(Text2));
        }
    }
}
