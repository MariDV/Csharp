using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class Program
    {

        static void Main(string[] args)
        {
            // Variables.body(); // what you call here will appear when you press start, now I'm calling class variable, but if I whant other variables I must call OtherVariables.body()*/
            //ArraysLibrary.body();

            //first function

            greetings("saygin", ConsoleColor.Green);
            greetings("siamak", ConsoleColor.Yellow);
            greetings("sina", ConsoleColor.DarkMagenta);
            greetings("jose", ConsoleColor.Blue);
            greetings("mariana", ConsoleColor.DarkRed);
            
            
            //second function

            saywelcome("Jose", "ITD Canada");
            saywelcome("Mariana", "ITD Canada");


            //my functions
            Console.WriteLine($"The result for add is" + add(5,10));
            Console.WriteLine($"The result for multiply is" + multiply(5,10));
            Console.WriteLine($"The result for add subtract is" +subtract(5,10));
            Console.WriteLine($"The result for divide is" + divide(5,10));
            /* Console.ForegroundColor = ConsoleColor.White;
             add(5,10);
             multiply(5, 10);
             substract(5, 10);
             divide(5, 10);*/

            Console.WriteLine(multiply(add(4,5),divide(20,10)));
            Console.ReadLine();
        }



        //-first function-
        //this is how I can explain what Im doing in my function
        /// <summary>
        /// This function asks for two parameters, 1st the name (must have), sencond one you can decide to use a default color.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        private static void greetings(string name, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"hello my name is {name}");
        }


        private static void saywelcome(string name, string school = "ITD")
        {
            Console.WriteLine($"hello {name}, welcome to {school}");
        }

        private static double add(double num1, double num2)
        {
            return num1 + num2;
        }

        //if you don't know how many numbers you can do it like this:
        /// <summary>
        /// create a params list, give a name, in this case args
        /// create a new variable (double), give a value
        /// say what is the operation
        /// ask to return
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private static double add(params double[] args)
        {
            double sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                sum += args[i];
            }
            return sum;
        }
        private static double add2(params double[] args)
        {
            StringBuilder sb = new StringBuilder();
            double sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                sb.Append(args[i].ToString());
                if (i == args.Length - 1) sb.Append(" ");
                else sb.Append(" + ");
                 sum += args[i];
            }
            sb.Append("= ");
            sb.Append(sum.ToString());
            Console.WriteLine(sb.ToString());
            return sum;
        }
        private static double multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        private static double subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        private static double divide(double num1, double num2)
        {
            return num1 / num2;
        }

        private static double newexerc(params double[] values)
        {
            StringBuilder texto = new StringBuilder();
            string[] numbers = new string[3] {"one", "two", "three"};
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                texto.Append(values[i].ToString());
                if (i == values.Length - 1) texto.Append(" ");
                else texto.Append(" , ");
                sum += values[i];
            }
            texto.Append("= ");
            texto.Append(sum.ToString());
            Console.WriteLine(texto.ToString());
            return sum;
        }





    }
}
