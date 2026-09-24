using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Array
{
    internal class TwoDimensionalArray
    {
        static void Main()
        {
            int[,] matrix = new int[2, 3];

            matrix[0, 0] = 10;
            matrix[0, 1] = 20;
            matrix[0, 2] = 30;

            matrix[1, 0] = 40;
            matrix[1, 1] = 50;
            matrix[1, 2] = 60;

            for (int i = 0; i < matrix.GetLength(0); i++) //row -> 2
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //Columns -> 3
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


            int[,] num =
            {
                   {10, 20, 30 },
                   {11,22,33 }
            };




            int[,,] multi =
            {
                {
                    { 10, 20, 30 }, { 30, 40, 50 }, { 50, 60, 70 }
                },

                {
                    { 100, 200, 300 }, { 400, 500, 600 }, { 700, 800, 900 }
                }

            };

            Console.WriteLine("\n Multi Dimensional Array");

            for (int i = 0; i < multi.GetLength(0); i++)
            {
                for (int j = 0; j < multi.GetLength(1); j++)
                {
                    for(int k =0; k< multi.GetLength(2); k++)
                    {
                        Console.Write(multi[i, j, k] + " ");

                    }

                    Console.WriteLine();
                }
                Console.WriteLine();
            }


        }
    }
}
