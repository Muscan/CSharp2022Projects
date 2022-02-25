using System;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*Person.City = "Cluj-Napoca";
            Person.printCity();
            Person person = new Person();
            Person.City = "Bucuresti";
            Hobby hobby = new Hobby();
            hobby.date();
            person.date();
            person.nrPrime(6);
            Person hobby1 = new Hobby();
            Person student = new Student();
            Person[] pers = new Person[2];*/

            //ThreeSimple.Calculate();

            //Polymorphism
            //methods are called from the Instantiaded object(Pig, Dog, Cow)
            Animal animal = new Animal();
            Animal pig = new Pig();
            Animal dog = new Dog();
            Animal cow = new Cow();

            pig.animalSound();
            dog.animalSound();
            cow.animalSound();

            Animal[] animals = new Animal[4];

            animals[0] = animal;
            //ind id 10 = cow has another id(15) but only base class id will be called
            animals[1] = cow;
            animals[2] = dog;
            animals[3] = pig;

            for(int i=0; i< 4; i++)
            {
                animals[i].animalSound();
            }
            //For Attributes, only the ones from base class is disaplayed
            for(int i=0; i<4; i++)
            {
                Console.WriteLine(animals[i].id);
            }
        }
    }
}
