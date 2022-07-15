using Command.Models;
using Command.Repositories;

namespace Command.Commands
{
    public class AddToCartCommand : ICommand
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly Food _food;

        public AddToCartCommand(
            IShoppingCartRepository shoppingCartRepository,
            IFoodRepository foodRepository,
            Food food)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _foodRepository = foodRepository;
            _food = food;
        }

        public bool CanExecute()
        {
            return _foodRepository.GetCountFor(_food.Id) > 0;
        }

        public void Execute()
        {
            _foodRepository.DecreaseCountBy(_food.Id, 1);

            _shoppingCartRepository.Add(_food);
        }

        public void Undo()
        {
            var lineItem = _shoppingCartRepository.Get(_food.Id);

            _foodRepository.IncreaseCountBy(_food.Id, lineItem.Quantity);

            _shoppingCartRepository.RemoveAll(_food.Id);
        }
    }
}
