using Command.Commands;
using Command.Models;
using Command.Repositories;

namespace Command.WPF.ViewModels
{
    public class FoodViewModel
    {
        public Food Food { get; set; }
        public int Quantity { get; set; }

        public System.Windows.Input.ICommand AddToCartCommand { get; private set; }
        public System.Windows.Input.ICommand IncreaseQuantityCommand { get; private set; }
        public System.Windows.Input.ICommand DecreaseQuantityCommand { get; private set; }
        public System.Windows.Input.ICommand RemoveFromCartCommand { get; private set; }
        
        public FoodViewModel(ShoppingCartViewModel shoppingCartViewModel,
            IShoppingCartRepository shoppingCartRepository,
            IFoodRepository foodRepository,
            Food food,
            int quantity = 0)
        {
            Food = food;
            Quantity = quantity;

            var addToCartCommand = 
                new AddToCartCommand(shoppingCartRepository, foodRepository, food);

            var increaseQuantityCommand = 
                new ChangeQuantityCommand(ChangeQuantityCommand.Operation.Increase, 
                    shoppingCartRepository, 
                    foodRepository, 
                    food);

            var decreaseQuantityCommand = 
                new ChangeQuantityCommand(ChangeQuantityCommand.Operation.Decrease, 
                    shoppingCartRepository,
                    foodRepository, 
                    food);

            var removeFromCartCommand = 
                new RemoveFromCartCommand(shoppingCartRepository, 
                    foodRepository, 
                    food);

            AddToCartCommand = new RelayCommand(
                    execute: () => {
                        addToCartCommand.Execute();
                        shoppingCartViewModel.Refresh();
                    },
                    canExecute: () => addToCartCommand.CanExecute());

            IncreaseQuantityCommand = new RelayCommand(
                execute: () => {
                    increaseQuantityCommand.Execute();
                    shoppingCartViewModel.Refresh();
                },
                canExecute: () => increaseQuantityCommand.CanExecute());

            DecreaseQuantityCommand = new RelayCommand(
                execute: () => {
                    decreaseQuantityCommand.Execute();
                    shoppingCartViewModel.Refresh();
                },
                canExecute: () => decreaseQuantityCommand.CanExecute());

            RemoveFromCartCommand = new RelayCommand(
                execute: () => {
                    removeFromCartCommand.Execute();
                    shoppingCartViewModel.Refresh();
                },
                canExecute: () => removeFromCartCommand.CanExecute());
        }
    }
}
