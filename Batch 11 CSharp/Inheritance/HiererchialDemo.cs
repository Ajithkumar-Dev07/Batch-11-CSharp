using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Inheritance
{
    class ManagerClass
    {
        public int staff;
        public string task;
        public void  DisplayReport()
        {
            Console.WriteLine("Staff No:  "+ staff);
            Console.WriteLine("Completed task:  "+ task);
        }
    }
    class Staf1 : ManagerClass
    {
        public string Name;
        public Staf1()
        {
            staff = 1;
            task = "Testing Functality";
        }
    }
    class Staf2 : ManagerClass
    {
        public Staf2()
        {
            
            staff = 2;
            task = "Deploying Code";
        }
    }
    class Staf3 :ManagerClass
    {
        public Staf3()
        {
            staff = 3;
            task = "Production Support";
        }
    }
    internal class HiererchialDemo
    {
        static void Main()
        {
            Staf1 s1 = new Staf1();

            s1.DisplayReport();

            Console.WriteLine();

            Staf2 s2 = new Staf2();

            s2.DisplayReport();
        }
    }
}
