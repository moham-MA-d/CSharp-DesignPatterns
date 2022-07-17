using Facade.Models;

namespace Facade.Services
{
    public class PaymentService
    {
        public int GetPrice(string foodName)
        {
            return foodName switch
            {
                "Pizza" => 20,
                "Sandwich" => 12,
                "Kebab" => 25,
                "Chicken" => 15,
                _ => 0
            };
        }
    }
}