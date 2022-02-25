using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Animal
    {
        public int id = 10;
        public virtual void animalSound()
        {
            Console.WriteLine("Animal sound.");
        }
    }
}
