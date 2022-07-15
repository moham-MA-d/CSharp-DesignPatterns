using Command.Repositories;

namespace Command.Commands
{
    public class RemoveAllFromCartCommand : ICommand
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IFoodRepository _foodRepository;

        public RemoveAllFromCartCommand(IShoppingCartRepository shoppingCartRepository,
            IFoodRepository foodRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _foodRepository = foodRepository;
        }

        public bool CanExecute()
        {
            return _shoppingCartRepository.All().Any();
        }

        public void Execute()
        {
            var items = _shoppingCartRepository.All().ToArray(); // Make a local copy

            foreach (var lineItem in items)
            {
                _foodRepository.IncreaseCountBy(lineItem.Food.Id, lineItem.Quantity);

                _shoppingCartRepository.RemoveAll(lineItem.Food.Id);
            }
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
