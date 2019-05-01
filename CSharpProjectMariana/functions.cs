using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class functions
    {
        public static void body() {
            if (!true)
            {
                greetings("saygin", ConsoleColor.Green);
                greetings("siamak", ConsoleColor.Yellow);
                greetings("sina", ConsoleColor.DarkMagenta);
                greetings("jose", ConsoleColor.Blue);
                greetings("mariana", ConsoleColor.DarkRed);


                //second function

                saywelcome("Jose", "ITD Canada");
                saywelcome("Mariana", "ITD Canada");


                //my functions
                Console.WriteLine($"The result for add is" + add(5, 10));
                Console.WriteLine($"The result for multiply is" + multiply(5, 10));
                Console.WriteLine($"The result for add subtract is" + subtract(5, 10));
                Console.WriteLine($"The result for divide is" + divide(5, 10));
                Console.ForegroundColor = ConsoleColor.White;
                add(5, 10);
                multiply(5, 10);
                subtract(5, 10);
                divide(5, 10);

                Console.WriteLine(multiply(add(4, 5), divide(20, 10)));
                Console.ReadLine();
                //}
            }

            if (!true)
            {

                //-first function-
                //this is how I can explain what Im doing in my function
                /// <summary>
                /// This function asks for two parameters, 1st the name (must have), sencond one you can decide to use a default color.
                /// </summary>
                /// <param name="name"></param>
                /// <param name="color"></param>
                void greetings(string name, ConsoleColor color = ConsoleColor.White)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine($"hello my name is {name}");
                }


                void saywelcome(string name, string school = "ITD")
                {
                    Console.WriteLine($"hello {name}, welcome to {school}");
                }

                double add(double num1, double num2)
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
                double add9(params double[] args)
                {
                    double sum = 0;
                    for (int i = 0; i < args.Length; i++)
                    {
                        sum += args[i];
                    }
                    return sum;
                }
                double add2(params double[] args)
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
                double multiply(double num1, double num2)
                {
                    return num1 * num2;
                }
                double subtract(double num1, double num2)
                {
                    return num1 - num2;
                }
                double divide(double num1, double num2)
                {
                    return num1 / num2;
                }
            }

            if (!true)
            {
                /*void numtowords(int values)
        {
            int _values = Convert.ToInt32(values);
            String name = " ";
            switch (values)
            {

                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
            }
            return;
        }
    }
    //public static int countDigit(int values)
    {
        if (values < 0)
        {

        }
    }
    //public static int reverse(int values)
    {
        int reverse = 0;
        int lastDigit;
        int original = values;
        if (values < 0)
        {
            values *= -1;
        }

        while (values > 0)
        {
            lastDigit = values % 10;
            reverse *= 10;
            reverse += lastDigit;
            values /= 10;
        }
        if (original > 0)
        {

        }
    }*/
            }

            //pass by value function increment
            int number1 = 10;
            Console.WriteLine($"before calling the function the number value is{number1}");
            Console.WriteLine($"the value inside the function is {incrementTheValue(number1)}");
            Console.WriteLine($"after calling the function the number value is {number1}");

            //pass by reference function decrement
            int number2 = 10;
            Console.WriteLine($"before calling the function the number value is{number2}");
            Console.WriteLine($"the value inside the function is {decrementTheValue(ref number2)}");
            Console.WriteLine($"after calling the function the number value is {number2}");

            //pass by reference function transferTenDolars
            double balance = 1000;
            Console.WriteLine($"before calling the function the balance is{balance}");
            Console.WriteLine($"the value inside the function is {transferTenDolars(ref balance)}");
            Console.WriteLine($"after calling the function the balance is {balance}");


            //pass by reference
            double transferTenDolars(ref double money)
            {
                money -= 10.0;
                return money;
            }


            //pass by value
            int incrementTheValue(int a)
            {
                a += 1;
                return a;
            }
            
            
            //pass by reference
            int decrementTheValue(ref int a)
            {
                a -= 1;
                return a;
            }

            
        }
    }
}
  
