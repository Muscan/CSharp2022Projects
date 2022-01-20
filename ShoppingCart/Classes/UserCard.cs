namespace ShoppingCart.Classes
{
    internal class UserCard
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        
        public Card Card { get; set; }

        public UserCard()
        {

        }

        public UserCard(int id, string name, Card card)
        {
            this.Id = id;
            this.Name = name;
            this.Card = card;
        }

        public override string ToString()
        {
            return Id + "," + Name +  "," + Card ;
        }
    }
}
