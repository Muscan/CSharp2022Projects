using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ThreeSimple
    {
        //a.....b 7....100 6l....2000rkm
        //c.....x 12....x  8km....xlitri
        //=>x=(c*b)/a;
        public static void Calculate()
        {
            double a; 
            double b;
            double c;
            Console.WriteLine("Enter nr 1");

            string s = Console.ReadLine();
            
            a = Convert.ToDouble(s);
            Console.WriteLine("Enter second nr ");
            s = Console.ReadLine();
            b = Convert.ToDouble(s);
            Console.WriteLine("Enter third nr. ");
            s= Console.ReadLine();
            c = Convert.ToDouble(s);
            double x = (c * b) / a;
            Console.WriteLine("Result "+x);

        }
    }
}
