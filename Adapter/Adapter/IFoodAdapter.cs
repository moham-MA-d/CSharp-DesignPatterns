using Adapter.Model;

namespace Adapter.Adapter
{
    public interface IFoodAdapter
    {
        IEnumerable<Food>? GetFoods();
    }
}
