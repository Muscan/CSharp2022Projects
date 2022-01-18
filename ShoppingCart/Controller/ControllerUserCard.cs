using ShoppingCart.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Controller
{
    internal class ControllerUserCard
    {
        private List<UserCard> usersCards;
       
        public ControllerUserCard()
        {
            usersCards = new List<UserCard>();
            //ReadUsersFromFile();
        }

        public void ReadUsersFromFile()
        {
            StreamReader read = new StreamReader(@"../../../Files/UsersCardsFile.txt");
            String line = read.ReadLine();
            while (line != null)

            {
                string[] parts = line.Split(",");
                int id = int.Parse(parts[0]);
                string name = parts[1];
                string card = parts[2];
                double amount = double.Parse(parts[3]);
                usersCards.Add(new UserCard(id, name, card, amount)); 
                line = read.ReadLine();
            }
            read.Close();
        }

        public void SaveToFileAmount()
        {
            StreamWriter writeAmount = new StreamWriter(@"../../../Files/AvailableStock.txt");
            writeAmount.WriteLine(usersCards.ToString());
            writeAmount.Close();
        }
    }
  

}
