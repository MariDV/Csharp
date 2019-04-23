using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class ConditionalStatements
    {
        public static void body() {

            string userInput;
                       
            Console.Write("how old are you?" );
            userInput = Console.ReadLine();

            int resposta;
            bool itsok = int.TryParse(userInput, out resposta);
            int thisYear = (DateTime.Now).Year;
            if (itsok)
            {
                if (resposta < 0)
                {
                    Console.WriteLine("stop this, no negative numbers");
                }
                else
                {
                    if (resposta > 100)
                    {
                        Console.WriteLine("Dude, you are probably dead..");
                    }
                    Console.WriteLine($"You were born at {thisYear - resposta}");
                }
            } else
            {
                Console.WriteLine($"THIS IS NOT A NUMBER mothafoca");
            }

            //------------_____________________-------------------___________________-----------------------___________________________

            //and operator &&
            //or operator ||

            //exemplos de uso && , ||
              
            string weather = "rainy";
            bool haveUmbrella = true;
            if (weather == "rainy" && haveUmbrella)
            {
                Console.WriteLine("You are safe and dry");
            }
            if (weather == "rainy" && !haveUmbrella)
            {
                Console.WriteLine("Ops, you will get wet as hell");
            }

            string program1 = "general programming";
            string program2 = "e-commerce";
            Console.WriteLine("what is your program?");
            string userprogram = Console.ReadLine();

            if(userprogram == program1 || userprogram == program2)
            {
                Console.WriteLine("you are in IT department");

            }
            else
            {
                Console.WriteLine("you are not in IT department");
            }

            





            Console.ReadLine();
}
    }
}
