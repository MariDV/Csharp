using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.speak();
            Teacher teacher1 = new Teacher();
            teacher1.speak();
            Console.ReadLine();
        }
    }
}
