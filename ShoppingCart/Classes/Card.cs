using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Classes
{
    internal class Card
    {
        public int Id { get; set; }
        public double Amount { get; set; }

        public Card()
        {

        }

        public Card(int id, double amount)
        {
            this.Id = id;
            this.Amount = amount;  

        }

        public override string ToString()
        {
            return Id + "," + Amount;
            
        }
    }



}
