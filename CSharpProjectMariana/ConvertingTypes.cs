using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class ConvertingTypes
    {
        public static void body()
        {
            //string to integer
            string age = "10";
            Console.WriteLine($"you are {age} years old"); // you are 10 years old
            Console.WriteLine($" you will be {age+1} years old next year"); //you will be 101 years old next year

            int integerage = int.Parse(age);
            Console.WriteLine($"you will be {integerage+1} years old next year");//you will be 11 years old next year

            string anumber = "one";
            int result;
            bool canConvert = int.TryParse(anumber, out result);

            Console.WriteLine($"canConvert \"one\" value is {canConvert}"); //false
            Console.WriteLine("convertion result is " + result);

            anumber = "1";
            canConvert = int.TryParse(anumber, out result);
            Console.WriteLine($"canConvert \"1\" value is {canConvert}"); //true
            Console.WriteLine("convertion result is " + result);

            //integer to string
            int year = 2019;
            string stringYear = year.ToString();
            string last2digits = stringYear.Substring(2, 2);
            Console.WriteLine(last2digits);

        }
    }
}
