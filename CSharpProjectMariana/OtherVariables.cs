using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class OtherVariables
    {
        enum weekdays
        {
            Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 //every item has a index number Monday should be 0, but you can change that information.*/
        }

        struct dog
        {
            public int BirthYear;
            public string name;
            public bool isFriendly;

            public void WhoAreYou()
            {
                Console.WriteLine($"Hello my name is {name}," + $"I was born at {BirthYear} " + $"people say I am friendly thats {isFriendly}.");
            }
        }
            public static void body()
            {
                Console.WriteLine("test for static other variables");
                Console.WriteLine(weekdays.Monday);
                Console.WriteLine($"the enum weekdays monday is: {weekdays.Monday.ToString()}");
                Console.WriteLine((int)weekdays.Monday); //this way you can see the number(index) conected with this object.*/
                Console.WriteLine($"the enum weekdays monday value is: {(int)weekdays.Monday}");
                Console.WriteLine("\n\n");

                dog puppy;
                puppy.BirthYear = 2018;
                puppy.name = "Aylla";
                puppy.isFriendly = true;
                puppy.WhoAreYou();
                //Console.WriteLine($"Hello my name is {puppy.name}," + $"I was born at {puppy.BirthYear} " + $"people say I am friendly thats {puppy.isFriendly}.");
                Console.WriteLine("\n\n");


                Console.WriteLine("\n");
                Console.WriteLine("\t this is a tab");
                Console.WriteLine("/\\/\\");
                Console.WriteLine("she said \"yes\"");
                Console.WriteLine("helll\boo");
                Console.WriteLine("\a");
                Console.WriteLine("this is the symbol of PI \u03c0");
                Console.WriteLine("\n");

                string testString = "hellooooo C sharp!       ";
                Console.WriteLine($"original string is \t{testString}");
                Console.WriteLine($"testString.Substring(5) \t{testString.Substring(5)}");
                Console.WriteLine($"testString.Substring(10,7) \t{testString.Substring(10,7)}");
                Console.WriteLine($"testString.Remove(5) \t{testString.Remove(5)}");
                Console.WriteLine($"testString.Remove(5,4) \t{testString.Remove(5,4)}");
                Console.WriteLine($"testString.Remove(11) \t{testString.Remove(11)}#!");
                Console.WriteLine($"testString.Replace(one,other) \t {testString.Replace("sharp","#!")}");
                Console.WriteLine($"testString.Replace(one,other) \t {testString.Replace("sharp", "#!").Trim()}");
                Console.WriteLine($"testString.Replace(one,other) \t {testString.Replace("sharp", "#!").Trim().ToUpper()}");
                Console.WriteLine($"testString.Replace(one,other) \t {testString.Replace("sharp", "#!").Trim().ToUpper().Remove(5,4).Remove(7,1)}");





            Console.ReadLine(); //you need this to see the value when pressing start

        }
    }
}

