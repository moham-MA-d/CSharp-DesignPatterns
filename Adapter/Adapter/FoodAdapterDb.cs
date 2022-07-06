using Adapter.Model;
using Adapter.Repository;

namespace Adapter.Adapter
{
    public class FoodAdapterDb : IFoodAdapter
    {
        private readonly FoodRepositoryDb _foodRepositoryDb;
        public FoodAdapterDb(FoodRepositoryDb foodRepositoryDb)
        {
            _foodRepositoryDb = foodRepositoryDb;
        }

        public IEnumerable<Food> GetFoods()
        {
            return  _foodRepositoryDb.GetFoodsFromDb();
        }
    }
}
