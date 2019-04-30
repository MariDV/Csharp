using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class ArraysLibrary
    {
        public static void body()
        {
            float[,] floarArr = new float[2, 5];
            for (int i = 0; i < floarArr.GetLength(0); i += 1)
            {
                for (int j = 0; j < floarArr.GetLength(1); j += 1)
                {
                    floarArr[i, j] = (i* floarArr.GetLength(1)) + j+1;
                }
            }

            for (int i = 0; i < floarArr.GetLength(0); i += 1)
            {
                for (int j = 0; j < floarArr.GetLength(1); j += 1)
                {
                    Console.WriteLine($"floatArr[{i},{j}]={floarArr[i, j]}");
                    Console.ReadLine();
                }
            }
        }
    }
}
