using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Dog : Animal
    {
        public int id = 120;
        public override void animalSound()
        {
            Console.WriteLine("Dog sound");
          
        }
    }
}
