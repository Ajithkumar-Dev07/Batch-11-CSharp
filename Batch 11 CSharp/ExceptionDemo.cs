using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    public class InputOddExcepetion : Exception
    {
        public InputOddExcepetion(string message) : base(message)
        {
            
        }
    }
    internal class ExceptionDemo
    {
        
        static int Main()
        {
            try
            { 
                Console.WriteLine("Enter the First No: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Second No: ");
                int num2 = int.Parse(Console.ReadLine());


                //if(num2 % 2 != 0)
                //{
                //    throw new InputOddExcepetion("Given number is Odd value");
                //}
                

                double div = num1 / num2;

               
               
                Console.WriteLine("Result = "+ div);

                string message = null;

                //if(message == null)
                //{
                //    throw new NullReferenceException("Null value is Initilaized");
                //}


                //Console.WriteLine("Length of message: " + message.Length);

            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Error occurs: "+ex.Message);
                Console.WriteLine("Type of Excpetion: "+ex.GetType());
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error occurs: " + ex.Message);
                Console.WriteLine("Type of Excpetion: " + ex.GetType());
            }
            catch(ApplicationException ex)
            {
                Console.WriteLine("Error occurs: " + ex.Message);
                Console.WriteLine("Type of Excpetion: " + ex.GetType());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error occurs: " + ex.Message);
                Console.WriteLine("Type of Excpetion: " + ex.GetType());
            }
            finally
            {
                Console.WriteLine("End of the Program....");
            }
            return 0;
        }
    }
}
