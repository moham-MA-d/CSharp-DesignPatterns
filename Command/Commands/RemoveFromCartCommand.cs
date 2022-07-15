using Command.Models;
using Command.Repositories;

namespace Command.Commands
{
    public class RemoveFromCartCommand : ICommand
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly Food _food;

        public RemoveFromCartCommand(IShoppingCartRepository shoppingCartRepository,
            IFoodRepository foodRepository,
            Food food)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _foodRepository = foodRepository;
            _food = food;
        }

        public bool CanExecute()
        {
            return _shoppingCartRepository.Get(_food.Id).Quantity > 0;
        }

        public void Execute()
        {
            var lineItem = _shoppingCartRepository.Get(_food.Id);

            _foodRepository.IncreaseCountBy(_food.Id, lineItem.Quantity);

            _shoppingCartRepository.RemoveAll(_food.Id);
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
