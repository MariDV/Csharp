using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class Variables
    {

        public static void body() { 
        //this is single line comment
        /*
         this is multi line comment
         boolean value is true or false
         you have to initialize boolean value before using it
         */
        bool booleanVar = false;
        Console.WriteLine("the booleanVar value is either {0} or {1}", booleanVar, !booleanVar);
            Console.WriteLine("the booleanVar value is either " + booleanVar + "or " + !booleanVar);
            Console.WriteLine($"the booleanVar value is either {booleanVar} or {!booleanVar}");
            Console.WriteLine($"the size of the boolean is {sizeof(bool)} byte");
            Console.WriteLine($"\n");

            byte bytevar = 1;
        Console.WriteLine($"the byteVar value is {bytevar}");
            Console.WriteLine($"the max value for byte is: {byte.MaxValue}");
            Console.WriteLine($"the max value for byte is: {byte.MinValue}");
            Console.WriteLine($"the size of byte is {sizeof(byte)} byte");
            Console.WriteLine($"\n");

            sbyte sbytevar = 2;
        Console.WriteLine($"the sbyteVar value is {sbytevar}");
            Console.WriteLine($"the max value for sbyte is: {sbyte.MaxValue}");
            Console.WriteLine($"the max value for sbyte is: {sbyte.MinValue}");
            Console.WriteLine($"the size of sbyte is {sizeof(sbyte)} bytes");
            Console.WriteLine($"\n");

            char charvar = 'S';
        Console.WriteLine($"the charVar value is {charvar}");
            Console.WriteLine($"the size of char is {sizeof(char)} bytes");
            Console.WriteLine($"\n");

            char charVarUnide = '\u01A9';
        Console.WriteLine($"The charVarUnide value is {charVarUnide}");
            Console.WriteLine($"\n");

            decimal decimalVar = 15_415_498_714m;
        Console.WriteLine($"the decimalVar value is {decimalVar}");
            Console.WriteLine("formatted decimalVar is: "+String.Format("{0:n0}", decimalVar));
            Console.WriteLine($"the max value for decimal is: {decimal.MaxValue}");
            Console.WriteLine($"the max value for decimal is: {decimal.MinValue}");
            Console.WriteLine($"the size of decimal is {sizeof(decimal)} bytes");
            Console.WriteLine($"\n");

            double doubleVar = 3.75d;
        Console.WriteLine($"the doubleVar value is {doubleVar}");
            Console.WriteLine($"the max value for double is: {double.MaxValue}");
            Console.WriteLine($"the max value for double is: {double.MinValue}");
            Console.WriteLine($"the size of double is {sizeof(double)} bytes");
            Console.WriteLine($"\n");

            float floatVar = 2.99f;
        Console.WriteLine($"the floatVar value is {floatVar}");
            Console.WriteLine($"the max value for float is: {float.MaxValue}");
            Console.WriteLine($"the max value for float is: {float.MinValue}");
            Console.WriteLine($"the size of float is {sizeof(float)} bytes");
            Console.WriteLine($"\n");

            int intvar = -12345;
        Console.WriteLine($"the intvar value is {intvar}");
            Console.WriteLine($"the max value for intvar is: {string.Format ("{0:no}", int.MaxValue)}");
            Console.WriteLine($"the max value for intvar is: {string.Format("{0:no}", int.MinValue)}");
            Console.WriteLine($"the size of intvar is {sizeof(int)} bytes");
            Console.WriteLine($"\n");

            uint uintvar = 12345;
        Console.WriteLine($"the uintvar value is {uintvar}");
            Console.WriteLine($"the max value for uintvar is: {string.Format("{0:no}", uint.MaxValue)}");
            Console.WriteLine($"the max value for uintvar is: {string.Format("{0:no}", uint.MinValue)}");
            Console.WriteLine($"the size of uintvar is {sizeof(uint)} bytes");
            Console.WriteLine($"\n");

            int intbinaryVar = 0b11_0110_1010_1010_1010_0001;
        int hexadecimalVar = 0x00ff_05ff;
        Console.WriteLine($"the intbinaryVar value is {intbinaryVar}");
            Console.WriteLine($"the hexadecimalVar value is {hexadecimalVar}");
            Console.WriteLine($"\n");


            long longvar = 1234567891234567L;
        Console.WriteLine($"the longvar value is {longvar}");
            Console.WriteLine($"the max value for longvar is: {string.Format("{0:no}", long.MaxValue)}");
            Console.WriteLine($"the max value for longvar is: {string.Format("{0:no}", long.MinValue)}");
            Console.WriteLine($"the size of long is {sizeof(long)} bytes");
            Console.WriteLine($"\n");

            //Console.ReadLine(); //you need this to see the value when pressing start
        }
    }
}
