using Command.Models;

namespace Command.Repositories;

public interface IShoppingCartRepository
{
    (Food Food, int Quantity) Get(string id);
    IEnumerable<(Food Food, int Quantity)> All();
    void Add(Food food);
    void RemoveAll(string id);
    void IncreaseQuantity(string id);
    void DecreaseQuantity(string id);
}