using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    abstract class Calaulation
    {
        public int Count;

        public Calaulation()
        {
            Console.WriteLine("Abstarct class constructor is Called");
        }

        public abstract void CalaculateCount();

        public void DisplayResult()
        {
            Console.WriteLine("Count = "+ Count);
        }


    }

    class Implentataion : Calaulation
    {
        public override void CalaculateCount()
        {
            Count += 1;
        }


    }
    internal class Abstraction
    {
        static void Main()
        {
            //Calaulation obj1 = new Calaulation();

            Calaulation obj = new Implentataion();
             
            obj.CalaculateCount();

            obj.DisplayResult();
        }
    }
}
