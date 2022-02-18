using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Classes
{
    internal class User
    {
        //constructor for admin
        public User(int ID, string UserName, string Password, bool IsAdmin, Card card)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsAdmin = IsAdmin;
            this.Card = card;
        }

        //user role
        public User(int ID, string UserName, string Password, Card card)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsAdmin = false;
            this.Card = card;
        }

        public int ID { get; set; } 
        public string UserName { get; set; }    
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public Card Card { get; set; }
        public String toSaveUser()
        {
            return ID + "," + UserName + "," + Password + "," + IsAdmin + "," + Card.ToString();
        }
    }
}
