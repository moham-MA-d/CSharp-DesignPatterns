using Chain_Of_Responsibility.Models;

namespace Chain_Of_Responsibility.Helpers
{
    public interface IHelper
    {
        void Finalize(Order order, Food food);
    }
}
