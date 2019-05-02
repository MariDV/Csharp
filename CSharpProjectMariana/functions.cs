using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class functions
    {
        public static void body()
        {
            
            if (!true)
            {
                //create an array

                int[] Numbers = new int[10] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };


                //for (int i = 0; i < Numbers.Length; i++)
                //{
                //    sum += i;
                //}
                Console.WriteLine($"The value of sum the entire Arr is {addArr(Numbers)}!");

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

                double rad = 5.2d;
                double pi = 3.1d;

                double pi2 = 3.141592d;
                //Console.WriteLine(Math.PI)
                Console.WriteLine(calculateCircleArea(rad, pi));//pi is 3
                Console.WriteLine(calculateCircleArea(rad, pi2));//more precise result

                // const -constant, no one can change that value 
                const string ipNumber = "199.23.243.103";

                int studentId;
                giveAnId(out studentId);
                studentId = 101;//that can be changed later because it is not a const
                Console.WriteLine(studentId);
                //ref : is pass by reference
                //in : must be initialized before passing as a argument
                //out : must be modified inside the method scope (scope = function)

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

                //pi value is constant will not change
                double calculateCircleArea(double radius, in double pii)
                {
                    return pi * radius * radius;
                }
                int giveAnId(out int id)
                {
                    id = 100;
                    return id;
                }

            }
                //CHALENGE: Create a method which takes 1 parameter of integer array and add all elements inside the array and returnthe result
                //ex : [1,2,0,5] -----> pass to function --------> return (1 + 2 + 0 + 5)

                /// <summary>
                /// i is the array that you need to imput to sum all value inside.
                /// </summary>
                /// <param name="i"></param>
                /// <returns></returns>
                int addArr(int[] i)
                {
                    int result = 0;
                    for (int J = 0; J < i.Length; J++)
                    {
                        result += i[J];
                    }

                    return result;
                }

                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"The factorial of number {num}!= ");


                for (int i = 0; i < 16; i++)
                {
                    Console.WriteLine($"fibonacci({i}) = {fibo(i)} ");
                }

            

            //recursion functions
            //calculate the factorial of a number (a function that calls it self)
            int factorial(int number)
            {
                if (number<=0)
                {
                    return -1;
                }
                else if(number == 1)
                {
                    return 1;
                }
                else
                {
                    return number * factorial(number - 1);
                }
            }

           
            //Calculate Fibonacci
            int fibo(int number)
            {
                if (number == 0)
                {
                    return 0;
                }
                if (number == 1)
                {
                    return 1;
                }
                return fibo(number - 1) + fibo(number - 2);
            }

            /*Console.WriteLine("please give me a number: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"The factorial of number {numero}!= ");
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"chalen({i}) = {chalen(i)} ");
            }
            void chalen(int val)
            {
                if (val < 1)
                {
                    Console.WriteLine("Ivalid Value");
                }
                for (int i = 1; i <= val; i++)
                {
                   if (val % i == 0)
                    {
                        Console.WriteLine(i + " ") ;
                    }
                }
                
            }*/
            

        }
    }
}
  
