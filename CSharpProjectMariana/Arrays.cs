using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class Arrays
    {
        public static void body()
        {
            string[] students = { "Siamak", "Sina", "Daniel", "Jose", "Mariana", "Alex", "Nayoa", "Wade", "Mykhailo" };
            for (int i = 0; i < students.Length; i++)
            {
                //sort in alphabetic order ---> Console.WriteLine("sorted students A-Z");
                //Array.Sort(students);
                Console.WriteLine(students[i]);
            }

            int[] numbers = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            /* for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine($"numbers[{i}]= {numbers[i]}");
             }*/
            //to clear---> 
            //Array.Clear(numbers, 2, numbers.Length);
            //Array.Resize(ref numbers, 20);
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Console.WriteLine(Array.IndexOf(numbers, 80));

            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }

            //ARRAY
            //if (!true) ;
            //multi dimentional arrays


            //2d array
            int[,] twodim = new int[2, 4]{
            {1,2,3,4},
            {21,22,23,24 }
        };


            //3d array                 z, y , x
            int[,,] threedim = new int[3, 2, 4]
            {
                {
                {1,2,3,4},
                {5,6,7,8 }
                },
                {
                    {11,22,33,44},
                    {55,66,77,88}
                },
                {
                    {111,222,333,444 },
                    {555,666,777,888 }
                }

            };
            //Console.WriteLine(threedim[1,3,4]);//dept-row-column

           





        }
    }
}
