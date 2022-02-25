using System;

namespace Exercises
{
    internal class Cow : Animal
    {
        public int id = 15;
        public override void animalSound()
        {
            Console.WriteLine("Cow sound");
        }
        
    }
}

