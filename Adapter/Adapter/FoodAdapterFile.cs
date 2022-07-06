using Adapter.Model;
using Adapter.Repository;

namespace Adapter.Adapter
{
    public class FoodAdapterFile : IFoodAdapter
    {
        private readonly string _fileName;
        private readonly FoodRepositoryFile _foodRepositoryFile;

        public FoodAdapterFile(string fileName, FoodRepositoryFile foodRepositoryFile)
        {
            _fileName = fileName;
            _foodRepositoryFile = foodRepositoryFile;
        }

        public IEnumerable<Food>? GetFoods()
        {
            return _foodRepositoryFile.GetFoodsFromFile(_fileName);
        }
    }
}
