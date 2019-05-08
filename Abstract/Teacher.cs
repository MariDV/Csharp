using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Teacher : person
    {
        public string expertise { get; set; }
        public override void speak()
        {
            base.speak();
            Console.WriteLine("Hey, Im a teacher");
        }
    }
}
