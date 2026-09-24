using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Array
{
    internal class JaggedArray
    {

        static void Main()
        {
            int[][] jaggArr = new int[2][];

            jaggArr[0] = new int[]{ 10, 20 };

            jaggArr[1] = new int[] { 11, 12, 13 };

            Console.WriteLine();

            for(int i=0; i < jaggArr.Length; i++)
            {
                for(int j=0; j < jaggArr[i].Length; j++)
                {
                    Console.Write(jaggArr[i][j]+"  ");
                }

                Console.WriteLine();
            }

        }
    }
}
