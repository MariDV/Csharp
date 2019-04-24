using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class randomNum
    {
       public static void body()
        {
            Random qualquercoisa = new Random();
            int blabla = qualquercoisa.Next(1, 10);
            Console.WriteLine("Guess a number between 1-10:");
            string userguess;
            userguess = Console.ReadLine();
            int resposta;
            bool allgood = int.TryParse(userguess, out resposta);
            Console.WriteLine("the invisible number is: " + blabla);

            if (allgood)
            {
                if (resposta > blabla)
                {
                    Console.WriteLine("It's less than that");
                }
                if (resposta < blabla)
                {
                    Console.WriteLine("It's greater than that");
                }
                if (resposta == blabla)
                {
                    Console.WriteLine("Congrats you are correct!!!");
                }
                else
                {
                    Console.WriteLine("please insert a number");
                }
            }
           
            Console.ReadLine();

            /*Console.WriteLine("Hey how old are you?");
            string userage = Console.ReadLine();
            int result;
            bool ageok = int.TryParse(userage, out result);
            if (ageok)
            {
                switch (result)
                {
                    case int checkAge when checkAge <0:
                        Console.WriteLine("It's invalid, sorry");
                        break;
                    case int checkAge when checkAge > 0 && checkAge <= 12:
                        Console.WriteLine("you are a kid");
                        break;
                    case int checkAge when checkAge > 12 && checkAge <= 17:
                        Console.WriteLine("you are not an adult yet");
                        break;
                    case int checkAge when checkAge >=18 && checkAge <100:
                        Console.WriteLine("you are an adult");
                        break; 
                }
            }*/



        }


    }
}
