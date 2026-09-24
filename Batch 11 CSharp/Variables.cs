using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    internal class Variables
    {
        //static variable

        static int Id;

        //Instance varaibel

        string Department;

        //const

        const double pi = 3.14;

        //readonly

        readonly string Message;

        public Variables()
        {
            Message = "Hello";
        }



        static void Initialize1()
        {
            Id = 100;
        }

        public void InitDepat(string Dept)
        {
            Department = Dept;

            // pi = 3000;

            //Message = "Hello";
        }
        

        static void Display(Variables obj)
        {
            Console.WriteLine("Id  = "+Id);

            Console.WriteLine("Department = "+ obj.Department);

            Console.WriteLine("Pi = "+ pi);

            Console.WriteLine("Message ="+ obj.Message);
        }

        static void Main()
        {
            int x = 200;

            Console.WriteLine("x in main method = "+ x);

            if(true)
            {
                int y = 200;
            }

            Initialize1();
            //Display();

            Console.WriteLine("Instance Variable");

            Variables obj = new Variables();

            obj.Department = "HR";

            Display(obj);

            Variables obj1 = new Variables();

            obj1.Department = "Manager";

            Display(obj1);

            //Console.WriteLine("y = "+y);\

            Console.WriteLine("\n Using Var Keyword");

            var Data = "Hello";

            var Data2 = 5252.73; 

            Console.WriteLine("Data = "+Data+ "  Type: "+ Data.GetType());

        }

        static void Access()
        {
            //Console.WriteLine("x = "+x);
        }
    }
}
