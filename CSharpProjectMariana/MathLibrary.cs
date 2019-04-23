using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class MathLibrary
    {
        public static void body()
        {
            
            int absNumber = Math.Abs(-5);
            Console.WriteLine($"absNumber is: {absNumber}");
            Console.ForegroundColor = ConsoleColor.Magenta;
            //power of a number 2 to the power of 10
            Console.WriteLine($"2 to the power of 10 is: { Math.Pow(2, 10)}");
            Console.ForegroundColor = ConsoleColor.White;
            //rounding numbers
            Console.WriteLine($"round Number 123.45 {Math.Round(123.45)}");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"round Number 123.55 {Math.Round(123.55)}");
            Console.ForegroundColor = ConsoleColor.White;

            //round up or round down
            Console.WriteLine($"floor the number 999.999 {Math.Floor(999.999)}"); //999
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"ceiling the number 999.001 {Math.Ceiling(999.001)}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"log the number 1000 {Math.Log10(1000)}");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"compare 2 numbers 5 and 10 and return max{Math.Max(5, 10)}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"compare 2 numbers 5 and 10 and return min {Math.Min(5,10)}");
            Console.ForegroundColor = ConsoleColor.Magenta;





            Console.ReadLine();
        }
    }
}
