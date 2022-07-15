using Command.Models;

namespace Command.Repositories;

public interface IFoodRepository
{
    Food? FindBy(string id);
    int GetCountFor(string id);
    IEnumerable<Food> All();
    void DecreaseCountBy(string id, int amount);
    void IncreaseCountBy(string id, int amount);
}