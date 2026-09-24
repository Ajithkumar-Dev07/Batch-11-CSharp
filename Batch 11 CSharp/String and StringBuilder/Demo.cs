using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.String_and_StringBuilder
{
    internal class Demo
    {
        static void Main()
        {
            string str = "Hello";

            Console.WriteLine(str+"  "+str.GetType());

            Console.WriteLine("3rd character = "+ str[2]);

            string message = "Java Programming";

            //Replace

            message = message.Replace("Java", "C#");

            Console.WriteLine("Message = " + message);

            //Length

            Console.WriteLine("Length = "+ str.Length);

            //Substring

            string newMasg = message.Substring(3);

            Console.WriteLine(newMasg);

            

            newMasg = message.Substring(2, 7);


            Console.WriteLine(newMasg);

            string email = "ajith@gmail.com";

            Console.WriteLine(email.Contains("@"));

            Console.WriteLine(email.EndsWith(".com"));

            string s1 = "Hello";
            string s2 = "Hello";

            Console.WriteLine(s1 == s2);

            char[] arr = { 'H', 'E', 'L', 'L', 'O' };

            string s3 = new string(arr);

            Console.WriteLine(s3);

        }
    }
}
