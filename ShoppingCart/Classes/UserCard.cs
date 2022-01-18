namespace ShoppingCart.Classes
{
    internal class UserCard
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        
        public string Card { get; set; }

        public double Amount { get; set; }

        public UserCard()
        {

        }

        public UserCard(int id, string name, string card, double amount)
        {
            this.Id = id;
            this.Name = name;
            this.Card = card;
            this.Amount = amount;
        }

        public override string ToString()
        {
            return Id + "," + Name +  "," + Card + "," + Amount;
        }
    }
}
