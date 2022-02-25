using System;

namespace Exercises
{
    internal class Pig : Animal {
        public int id = 30;
        public override void animalSound()
        {
            Console.WriteLine("Pig sound");
        }
    } 
}
