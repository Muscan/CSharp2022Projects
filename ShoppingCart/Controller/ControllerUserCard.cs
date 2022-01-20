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
        private int totalAmount;

        public ControllerUserCard()
        {
            usersCards = new List<UserCard>();
            ReadUsersFromFile();
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
                int idCard = int.Parse(parts[2]);
                double amount = double.Parse(parts[3]);
                usersCards.Add(new UserCard(id, name, new Card(idCard, amount))); ; 
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
        //addproduct calculate
        public int PayWithCardCalculate(int payment)
        {
            totalAmount += payment;
            return payment;
        }
        //remove product caluclate
        public int MinusFromCardCalculate(int payed)
        {
            totalAmount -= payed;
            return totalAmount;
        }
        public int GetBalance()
        {
            return totalAmount;
        }

        public UserCard ReturnUser(string name, int card)
        {
            for (int i = 0; i < usersCards.Count; i++)
            {
                if (name == usersCards[i].Name
                 && card == usersCards[i].Card.Id)
                {
                    return usersCards[i];
                }
            }
            return null;//not found
        }

        //sold
        public bool ReturnBalance(UserCard userCard, double totalPayment)
        {
            if (userCard.Card.Amount >= totalPayment)
            {
                return true;
            }
            return false;
            //return (userCard.Card.Amount >= totalPayment);
        }
        //minus from account
        public void PayWithtMoneyFromCard(UserCard userCard, double totalPayment)
        {
            userCard.Card.Amount -= totalPayment;
        }
    }
  
}
