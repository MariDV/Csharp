using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class Classexercise
    {
        public static void body()
        {
            Console.WriteLine("i -- j");
            int j = 729;

            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine($"{i} -- {j}");
                j = j / 3;
            }


            Console.WriteLine("i -- j");
            for (int x = 0, z = 729; x < 10; x += 2, z = z / 3)
            {
                Console.WriteLine($"{x} -- {j}");

            }


            if(true)
            {
                int i = 0;
                while (i < 10)
                {
                    Console.WriteLine(i);
                    i += 1;
                }
                i = 10;
                while (i > 0){
                    i -= 1;
                    if (i == 5) continue;
                    Console.WriteLine( i);
                }
            }
            Console.WriteLine("Hey,lets play :) Inser -3 to exit");
            Console.WriteLine("Please insert the first number ");
            string numeros="";
            double sumav = 0;
            int nums = 0;

            while (numeros != "-3")
            {
                numeros = Console.ReadLine();
                if (numeros == "-3") break;
                sumav += Double.Parse(numeros);
                Console.WriteLine($"What's number #{nums}? {numeros}");

                nums++;
            }
                    Console.WriteLine($"You inserted {nums - 2} numbers");
                    Console.WriteLine($"The average of your numbers is: {(sumav / (nums))}");
            Console.ReadLine();
        }
            }
            
            
           
           //lembrar que sumav/nums=average

        }

    


