using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjectMariana
{
    class ConditionalStatements
    {
        public static void body() {

            string userInput;
                       
            Console.Write("how old are you?" );
            userInput = Console.ReadLine();

            int resposta;
            bool itsok = int.TryParse(userInput, out resposta);

            if (itsok)
            {
                int datauser = int.Parse(userInput);
                int useryear = 2019 - datauser;
                Console.WriteLine($"You typed {datauser}");
                Console.WriteLine($"You were born at" + useryear);
            }
            else
            {
                Console.WriteLine($"THIS IS NOT A NUMBER mothafoca");
            }
            
            
            //Console.ReadLine();
}
    }
}
