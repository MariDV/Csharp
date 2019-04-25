using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class loops
    {
        public static void body()
        {
            for (int i = 0; i < 10; i += 1)
            {
                Console.WriteLine(i + " " + Math.Pow(2, i));
            }

            int sum = 0;
            for (int x = 0; x <= 100; x++)
            {
                sum += x;
                Console.WriteLine(x + " " + sum);
            }

            int plus = 0;
            for (int y = 0; y <= 1000; y++)
                if (y % 3 == 0 || y % 5 == 0)
                {
                    plus += y;
                    Console.WriteLine(y + " " + plus);
                }

            string adultOrNot;
            int age = 25;
            adultOrNot = (age > 18) ? "adult" : "not adult";
            Console.WriteLine($"your age is {age} and you are {adultOrNot}");

            Console.ReadLine();

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
                if (i == 15) break;
            }
            //only and only 1 line of code will be part of for loop
            //if there is no curly bracets
            for (double i = 1.1d; i < 2; i += .1)
            {
                Console.WriteLine(i);
                Console.WriteLine("next");
            }

            Console.WriteLine("i -- j");
            int j = 729;
            for(int i=0; i<10; i += 1)
            {
                Console.WriteLine($"{i} -- {j}");
                j = j / 3;
            }
        }
    }
}
