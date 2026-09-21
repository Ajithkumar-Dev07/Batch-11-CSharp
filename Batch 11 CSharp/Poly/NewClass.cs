using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Poly
{
    internal class NewClass
    {
        //Constructor Overloading

        public string Name;
        public int id;
        public bool isPresent;

        public NewClass()
        {
            Name = "Jhon";
            id = 23;
            isPresent = true;
        }

        public NewClass(string name, int Id, bool IsPresent)
        {
            Name = name;
            id = Id;
            isPresent = IsPresent;
        }

        public void Displaydetails()
        {
            Console.WriteLine("Name = "+Name);
            Console.WriteLine("Id = "+id);
            Console.WriteLine("isPresent = "+isPresent);
        }

        static void Main()
        {
            NewClass obj1 = new NewClass();

            obj1.Displaydetails();

            NewClass obj2 = new NewClass("Manoj", 23, true);

            obj2.Displaydetails();
        }
    }
}
