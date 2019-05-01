using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class Array_lib
    {
        public static void body()
        {
            if (!true)
            {
                int[][] jaggedArr = new int[3][];
                jaggedArr[0] = new int[2] { 1, 2 };
                jaggedArr[1]= new int[4] { 345, 34, 6, 3};
                jaggedArr[2]= new int[5] { 434, 323, 767, 9898, 111};
            }
            if (!true)
            {
                string[][] jaggedStringArr = new string[4][] {
                new string[] {"Pao"},
                new string[] { "Tapioca", "Pacoca", "Acai", "Carambola", "Caja"},
                new string[] { "Couve", "Ovos", "Frango" },
                new string[] { "Whey", "Cocada" }
            };
            }
            if (!true)
            {
                //to print the index 3 array, all elements one by one
                for (int j = 0; j < jaggedStringArr.Length; j++)
                {

                    for (int i = 0; i < jaggedStringArr[j].Length; i++)
                    {
                        Console.WriteLine(jaggedStringArr[j][i] + " ");
                    }
                    Console.WriteLine();
                }
            }
            if (!true)
            {
                //acces to the jagged array element
                Console.Write("the value of jaggedStringArr[3][1] : ");
                Console.WriteLine(jaggedStringArr[3][1]);//will print the second element from the 3rd array
            }
            if (!true)
            {
                double[][,] twoDjaggedArray = new double[4][,]
                {
                new double[2,5] {
                    {2.1d,5.3d,7.1d,9.2d,7.5d},
                    {2.8d,5.2d,7.6d,9.9d,7.2d}
                },
                new double[1,5] {
                    {5.2d,2.5d,6.7d,2.3d,7.8d}
                },
                new double[2,6] {
                    {1.1d,3.7d,5.6d,9.8d,9.9d,2.3d},
                    {4.4d,0.3d,5.5d,7.2d,1.9d,3.5d}
                },
                new double[2,5] {
                    {2.2d,3.3d,4.4d,5.5d,6.6d},
                    {2.1d,3.2d,4.3d,5.4d,6.5d}
                }
                };

                Console.WriteLine(twoDjaggedArray[2][1, 4]); //will print 1.9 (3rd array, 2nd array inside, 5th element)
            }
            Console.ReadLine();
        }
    }
}
