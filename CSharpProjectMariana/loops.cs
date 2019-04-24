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
                for (int i = 0; i < 10; i += 1) {
                Console.WriteLine(i + " " + Math.Pow(2,i));
            }



            int sum = 0;
            for (int x = 0; x <= 100; x++)
            {
                sum = sum + x;
                Console.WriteLine(x +" " +sum);
            }

            int plus = 0;
            for (int y = 0; y <= 1000; y++)
                if (y % 3==0 || y % 5 == 0)
                {
                    plus = y + plus;
                    Console.WriteLine(y + " " + plus);
                }
            





            Console.ReadLine();
        }
    }
}
