namespace Command.Models
{
    public class Food
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Food()
        {

        }

        public Food(string id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
