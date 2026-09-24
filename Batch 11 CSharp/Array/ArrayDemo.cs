using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Array
{
    internal class ArrayDemo
    {
        static void Main()
        {
            int[] IntergerArr = new int[5];

            IntergerArr[0] = 10;
            IntergerArr[1] = 20;
            IntergerArr[2] = 30;
            IntergerArr[3] = 40;
            IntergerArr[4] = 50;
            //IntergerArr[5] = 60;

            for(int i=0; i < IntergerArr.Length; i++)
            {
                Console.WriteLine("Num = "+ IntergerArr[i]);
            }

            Console.WriteLine();

            string[] city = { "Chennai", "Madurai", "Trichy" };

            foreach(string cityName in city)
            {
                Console.WriteLine(cityName);
            }


            int[] arr1 = { 100, 200, 300 };

            int[] arr2 = new int[3];

            System.Array.Copy(arr1, arr2, arr1.Length);

            Console.WriteLine();

            foreach(int num in arr2)
            {
                Console.WriteLine("arr2 values = "+ num);
            }

         }
    }
}
