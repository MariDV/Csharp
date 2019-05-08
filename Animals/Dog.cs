using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Icreatures , Ispecial
    {
        public bool isAlive { get; set ; }

        public void move()
        {
            Console.WriteLine("Jose doesn't like me chubby, so I'm running");
        }

        public void poo()
        {
            Console.WriteLine("Ops I just pooped inside the house ()*.*()"); ;
        }

        public void swim()
        {
            Console.WriteLine("Hello, I'm Shiva and I can swim seus putos");
        }
    }

}
