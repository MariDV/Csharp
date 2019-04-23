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

        }

    }
}
