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
        public User(int ID, string UserName, string Password, bool IsAdmin)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsAdmin = IsAdmin;
        }

        //user role
        public User(int ID, string UserName, string Password)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsAdmin = false;
           
        }

        public int ID { get; set; } 
        public string UserName { get; set; }    
        public string Password { get; set; }
        public bool IsAdmin { get; set; } 
        public String toSaveUser()
        {
            return ID + "," + UserName + "," + Password + "," + IsAdmin;
        }
    }
}
