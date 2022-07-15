using Command.Models;

namespace Command.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly Dictionary<string, (Food Food, int Quantity)> _lineItems = new();

        public IEnumerable<(Food Food, int Quantity)> All()
        {
            return _lineItems.Values;
        }

        public (Food Food, int Quantity) Get(string id)
        {
            if (_lineItems.ContainsKey(id))
            {
                return _lineItems[id];
            }

            return (default, default);
        }

        public void Add(Food food)
        {
            if (_lineItems.ContainsKey(food.Id))
            {
                IncreaseQuantity(food.Id);
            }
            else
            {
                _lineItems[food.Id] = (food, 1);
            }
        }

        public void DecreaseQuantity(string id)
        {
            if (_lineItems.ContainsKey(id))
            {
                var lineItem = _lineItems[id];

                if (lineItem.Quantity == 1)
                {
                    _lineItems.Remove(id);
                }
                else
                {
                    _lineItems[id] = (lineItem.Food, lineItem.Quantity - 1);
                }
            }
            else
            {
                throw new KeyNotFoundException($"Food with Id: {id} not in cart, please add first");
            }
        }

        public void IncreaseQuantity(string id)
        {
            if (_lineItems.ContainsKey(id))
            {
                var lineItem = _lineItems[id];
                _lineItems[id] = (lineItem.Food, lineItem.Quantity + 1);
            }
            else
            {
                throw new KeyNotFoundException($"Food with Id: {id} not in cart, please add first");
            }
        }

        public void RemoveAll(string id)
        {
            _lineItems.Remove(id);
        }
    }
}
