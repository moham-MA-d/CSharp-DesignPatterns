using Command.Models;
using Command.Repositories;

namespace Command.Commands
{
    public class ChangeQuantityCommand : ICommand
    {
        public enum Operation
        {
            Increase,
            Decrease
        }

        private readonly Operation _operation;
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly Food _food;

        public ChangeQuantityCommand(Operation operation,
            IShoppingCartRepository shoppingCartRepository,
            IFoodRepository foodRepository,
            Food food)
        {
            _operation = operation;
            _shoppingCartRepository = shoppingCartRepository;
            _foodRepository = foodRepository;
            _food = food;
        }

        public void Execute()
        {
            switch (_operation)
            {
                case Operation.Decrease:
                    _foodRepository.IncreaseCountBy(_food.Id, 1);
                    _shoppingCartRepository.DecreaseQuantity(_food.Id);
                    break;
                case Operation.Increase:
                    _foodRepository.DecreaseCountBy(_food.Id, 1);
                    _shoppingCartRepository.IncreaseQuantity(_food.Id);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public bool CanExecute()
        {
            return _operation switch
            {
                Operation.Decrease => _shoppingCartRepository.Get(_food.Id).Quantity != 0,
                Operation.Increase => (_foodRepository.GetCountFor(_food.Id) - 1) >= 0,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public void Undo()
        {
            switch (_operation)
            {
                case Operation.Decrease:
                    _foodRepository.DecreaseCountBy(_food.Id, 1);
                    _shoppingCartRepository.IncreaseQuantity(_food.Id);
                    break;
                case Operation.Increase:
                    _foodRepository.IncreaseCountBy(_food.Id, 1);
                    _shoppingCartRepository.DecreaseQuantity(_food.Id);
                    break;
            }
        }
    }
}
