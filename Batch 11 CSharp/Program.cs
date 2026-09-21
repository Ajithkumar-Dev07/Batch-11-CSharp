using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Conditial Statements

                //If, If-else, if else-if, Nested if, switch

            //if

                //Syntax 
                    if(condition)
                {
                    //code to execute
                }

            //if-else
                
                //Syntax 
                    if(condition)
                    {
                    //code to execute
                    }
                    else
                    {
                         //else block of code
                     }

               */

            Console.WriteLine("Enter a Number: ");
            int num =  int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine(num+ " is an even number");
            }
            else
            {
                Console.WriteLine(num+" is an Odd number");
            }

            Console.WriteLine("End of Programming...");
        }
    }
}
