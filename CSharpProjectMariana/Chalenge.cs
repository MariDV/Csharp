using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class Chalenge
    {
        public static void body()
        {

            for (int i = 0; i <= 10000; i++)
            {
                isPerfectNumber(i);
            }
            
           
            
            //for this function
            // perfect%i==0
            //perfect+=i
            //perfect < 0
           
        }
        static void isPerfectNumber(int perfect)
        {
            if (perfect < 0)
        
            {
                Console.WriteLine("Nao vale");
            }
            int num=0;
            for (int i = 1; i < perfect; i++)
            {
                if (perfect % i == 0)
                {
                    num += i;

                }
            }
            if(num == perfect)
            {
                Console.WriteLine($"--Uhul!! {perfect} It's a perfect number!");
            }
            else
            {
                Console.WriteLine($"so {perfect} It's not a perfect number!");
            }

        }
    }
}
