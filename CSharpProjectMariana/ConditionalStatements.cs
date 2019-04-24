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

            Console.WriteLine("menu");
            Console.WriteLine("1- option 1");
            Console.WriteLine("2- option 2");
            Console.WriteLine("3- option 3");
            Console.WriteLine("4- option 4");
            Console.WriteLine("5- option 5");
            Console.WriteLine("6- option 6");

            Console.WriteLine("select one of the options");
            string useroption = Console.ReadLine();
            switch (useroption)
            {
                case "1":
                    Console.WriteLine("you have selected 1");
                    break;
                case "2":
                    Console.WriteLine("you have selected 2");
                    break;
                case "3":
                    Console.WriteLine("you have selected 3");
                    break;
                case "4":
                    Console.WriteLine("you have selected 4");
                    break;
                case "5":
                    Console.WriteLine("you have selected 5");
                    break;
                case "6":
                    Console.WriteLine("you have selected 6");
                    break;

            }




            Console.ReadLine();
}
    }
}
