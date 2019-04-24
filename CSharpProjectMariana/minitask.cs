using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class minitask
    {
        public static void body()
        {
            string program1 = "general programming";
            string program2 = "ecommerce";
            string program3 = "graphic design";
            string program4 = "business administration";
            string program5 = "webdesign";
           

            Console.WriteLine("what is your program?");
            string userprogram = Console.ReadLine();

            if (userprogram == program1 || userprogram == program2 || userprogram == program5)
            {
                Console.WriteLine("you are in IT department");

            }
            if (userprogram == program3 || userprogram == program4)
            {
                Console.WriteLine("you are not in IT department");
            }
            else
            {
                Console.WriteLine("You don't belong to this school");
            }

            Console.WriteLine("menu");
            Console.WriteLine("A- Javascript");
            Console.WriteLine("B- Economy");
            Console.WriteLine("C- Photoshop");
            Console.WriteLine("D- How to drink water");
            Console.WriteLine("E- Sleep like a baby class");
           
            Console.WriteLine("select one extra class from the menu");
            string useroption = Console.ReadLine();
            switch (useroption)
            {
                case "A":
                case "a":
                    Console.WriteLine("you have selected Javascript");
                    break;
                case "B":
                case "b":
                    Console.WriteLine("you have selected Economy");
                    break;
                case "C":
                case "c":
                    Console.WriteLine("you have selected Photoshop");
                    break;
                case "D":
                case "d":
                    Console.WriteLine("you have selected How to drink water");
                    break;
                case "E":
                case "e":
                    Console.WriteLine("you have selected Sleep like a baby class");
                    break;
                default:
                    Console.WriteLine("This option does not exist :)");
                    break;

            }
           






            Console.ReadLine();
        }
    }
}
