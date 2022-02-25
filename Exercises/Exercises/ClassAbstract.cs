using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    //obligat sa folosesc abstract
    public abstract class ClassAbstract
    {
        //nu are implementare
        public abstract double nrPrime(double nr);
      
        
        public int nrPrime(int i)
        {
            return i;
        }
    }
}
