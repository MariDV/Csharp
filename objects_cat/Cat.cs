using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objects_cat
{
    class Cat
    {

        //properties
        public string Cat_name { get; set; }
        public string Cat_color { get; set; }
        public bool Cat_isCute { get; set; }
        public double Cat_bodyLenght { get; set; }
        public int Cat_energy { get; set; }
        public double Cat_weight { get; set; }
        public int Cat_hunger { get; set; }

        //methods


        public double Jump()
        {
            double catJump = Cat_bodyLenght * 6;
            if(Cat_energy >= 0)
            {
            int NewEnergy = Cat_energy - 5;
                
                return -1;
            }
            else
            {
                Console.WriteLine($"{Cat_name} jumped this hight {catJump},it energy level is now: {Cat_energy} and it weight is {Cat_weight - 0.1}lb");
                return 0;
            }
        }


        void sleep()
        {

            int rest = Cat_energy + 20;
            if (Cat_energy >= 100)
            {
                Console.WriteLine($"Time to wake kitty your energy level is full {rest}, you loose some weight too look {Cat_weight -0.2}lb!!");
            }
            else
            {
                Console.WriteLine($"Kitty need to rest, now your energy is {Cat_energy} and after sleep it will be arround {rest}");
            }
            
            return;
        }

        void eat()
        {
            
            if (Cat_energy<=100)
            {
               double catfood= Cat_energy + 10;
                Console.WriteLine($"Hey kitty, you need to eat something. How about tuna, it will make your energy higher {catfood}, right now your weight is {Cat_weight}, after eat will be {Cat_weight+0.2}lb");
            }
            else
            {
                Console.WriteLine($"You don't need to eat, you look fat");
            }

            return;
        }

        void sound()
        {
            Console.WriteLine("Meow =^.^=");
            Cat_energy -= 1;
            Cat_hunger -= 1;
         
        }

        bool itsHungry()
        {
            return Cat_hunger > 50;
        }

    }



}
