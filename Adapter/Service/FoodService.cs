using System.Text;
using Adapter.Adapter;

namespace Adapter.Service
{
    public class FoodService
    {
        private readonly IFoodAdapter _foodAdapter;
        public FoodService(IFoodAdapter foodAdapter)
        {
            _foodAdapter = foodAdapter;
        }

        public string ListCharacters()
        {
            var sb = new StringBuilder();
            
            var foods = _foodAdapter.GetFoods();
            if (foods == null) return sb.ToString();

            const int nameWidth = 10;
            sb.AppendLine($"{"NAME".PadRight(nameWidth)}   PRICE");
            
            foreach (var food in foods)
                sb.AppendLine($"{food.Name.PadRight(nameWidth)}   {food.Price}");

            return sb.ToString();
        }
    }
}
