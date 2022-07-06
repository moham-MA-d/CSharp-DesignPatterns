using Adapter.Model;

namespace Adapter.Repository
{
    public class FoodRepositoryDb
    {
        public IEnumerable<Food> GetFoodsFromDb()
        {
            var foods = new List<Food>()
            {
                new Food {Name = "Sandwich", Price = 10},
                new Food {Name = "Pizza", Price = 15},
                new Food {Name = "Kebab", Price = 19},
                new Food {Name = "Chicken", Price = 15},
            };
            return foods;
        }
    }
}