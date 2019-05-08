using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Student : person
    {
        public string program { get; set; }
        public override void speak()
        {
            Console.WriteLine("Hey, Im a student");
        }

        
    }
}
