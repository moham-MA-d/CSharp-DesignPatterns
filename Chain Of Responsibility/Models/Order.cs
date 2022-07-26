namespace Chain_Of_Responsibility.Models
{
    public class Order
    {
        public List<Food> OrderedFoods { get; } = new();
        public List<Restaurant> Restaurants { get; } = new();
        public List<Food> RegisteredFoods { get; } = new();
        public int Paid => OrderedFoods
            .Where(x => x.IsPaid)
            .Sum(item => item.Price);
            //-FinalizedPayments.Sum(payment => payment.Paid);
        public DeliveryStatus DeliveryStatus { get; set; } = DeliveryStatus.WaitingForPayment;
    }
}