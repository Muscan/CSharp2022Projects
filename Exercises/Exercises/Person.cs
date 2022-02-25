using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Person : ClassAbstract
    {
        protected String Name;
        private int Id;
        public static String City;
        

        public void printName()
        {
            Console.WriteLine(Name);
        }
        public static void printCity()
        {
            Console.WriteLine(City);
        }
        public virtual void date()
        {
            Console.WriteLine(DateTime.Now);
        }

        public override double nrPrime(double nr)
        {
            return nr;
        }


    }
}
