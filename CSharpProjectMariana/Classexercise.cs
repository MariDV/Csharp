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
            double nums = 1;
            
            while (numeros != "-3")
            {
                numeros = Console.ReadLine();
                Console.WriteLine($"That's number #{nums}: {numeros}");
                sumav += Double.Parse(numeros);
                nums += 1;
                if (numeros == "-3")
                {
                    Console.WriteLine($"You inserted {nums - 1} numbers");
                    Console.WriteLine($"The average of your numbers is: {(sumav / (nums-1))}");
                }
            }
            
            
            Console.ReadLine();
           //lembrar que sumav/nums=average

        }

    }
}

