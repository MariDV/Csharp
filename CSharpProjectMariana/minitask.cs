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
            Console.WriteLine("A- General Programming");
            Console.WriteLine("B- E-commerce");
            Console.WriteLine("C- Graphic Design");
            Console.WriteLine("D- B.A");
            Console.WriteLine("E- Webdesign");
           
            Console.WriteLine("select one of the options from the menu");
            string useroption = Console.ReadLine();
            switch (useroption)
            {
                case "A":
                    Console.WriteLine("you have selected General Programming");
                    break;
                case "B":
                    Console.WriteLine("you have selected E-commerce");
                    break;
                case "C":
                    Console.WriteLine("you have selected Graphic Design");
                    break;
                case "D":
                    Console.WriteLine("you have selected B.A");
                    break;
                case "E":
                    Console.WriteLine("you have selected Webdesign");
                    break;
                default:
                    Console.WriteLine("This option does not exist :)");
                    break;

            }




            Console.ReadLine();
        }
    }
}
