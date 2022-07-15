using Command.Models;

namespace Command.Repositories
{
    public class FoodsRepository : IFoodRepository
    {
        private Dictionary<string, (Food? Food, int Count)> Foods { get; }

        public FoodsRepository()
        {
            Foods = new Dictionary<string, (Food? Food, int Count)>();

            Add(new Food("1", "Pizza", 20), 2);
            Add(new Food("2", "Sandwich", 12), 1);
            Add(new Food("3", "Kebab", 25), 2);
            Add(new Food("4", "Chicken", 15), 3);
        }

        public void Add(Food food, int count)
        {
            Foods[food.Id] = (food, count);
        }

        public void DecreaseCountBy(string id, int amount)
        {
            if (!Foods.ContainsKey(id)) return;

            Foods[id] = 
                (Foods[id].Food, Foods[id].Count - amount);
        }

        public void IncreaseCountBy(string id, int amount)
        {
            if (!Foods.ContainsKey(id)) return;

            Foods[id] = 
                (Foods[id].Food, Foods[id].Count + amount);
        }

        public IEnumerable<Food> All()
        {
            return Foods.Select(x => x.Value.Food);
        }

        public int GetCountFor(string id)
        {
            return Foods.ContainsKey(id) ? Foods[id].Count : 0;
        }

        public Food? FindBy(string id)
        {
            return Foods.ContainsKey(id) ? Foods[id].Food : null;
        }
    }
}
