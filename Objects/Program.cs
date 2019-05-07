using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Backpack myBackpack = new Backpack(); //after = is the value
            myBackpack.material="fabric";
            myBackpack.pocket=5;
            myBackpack.color="black";
            myBackpack.size="large";
            myBackpack.weight=10.6;
            myBackpack.havewheels=false;

            myBackpack.printTheObjectProperties();
            Console.ReadLine();
        }
    }
}
