using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class Class1
    {
        public static void body()
        {
            Console.WriteLine("____________________________Let's play a game____________________________");
            Console.WriteLine($"Insert your name, please: ");
            string teunome = Console.ReadLine();
            Console.WriteLine($"So {teunome} do you think you can beat me?");
            Console.WriteLine("Start with a number which is greater than 50, \n we will need to decrement the number by 1 or 2 or 5 \n whoever gets to input 0 lose \n \n Please, insert your first");
            bool theEnd = false;
            bool start = true;
            int userplay = int.Parse(Console.ReadLine());
            int pcnum;

            while (theEnd)
            {
                if (start) {

                    Console.WriteLine($"Whats your number?{userplay}");

                }
            }


        }

         }
}


    





//if firstuserinput > 50 firstuserinput = gamestart
// pcNumber must be always - 1 or -2 or -5



