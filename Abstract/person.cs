using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual void speak()
        {
            Console.WriteLine("Hey, I'm a person");
        }
    }
}
