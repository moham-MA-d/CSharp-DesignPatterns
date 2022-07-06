using Adapter.Model;
using Newtonsoft.Json;

namespace Adapter.Repository
{
    public class FoodRepositoryFile
    {
        public IEnumerable<Food>? GetFoodsFromFile(string filename)
        {
            var foods = JsonConvert.DeserializeObject<List<Food>>(File.ReadAllText(filename));
            return foods;
        }
    }
}
