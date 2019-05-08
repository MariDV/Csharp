using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitty : Icreatures
    {
        public bool isAlive { get ; set ; }

        public void move()
        {
            Console.WriteLine("Hey, Im moving =^.^=");
        }

        public void poo()
        {
            Console.WriteLine("Hey my name is Jose, and Im pooping =^.^= meow");
        }
    }
}
