using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Command.Commands;
using Command.Repositories;

namespace Command.WPF.ViewModels
{

    public class ShoppingCartViewModel : ViewModelBase
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IFoodRepository _foodRepository;

        public System.Windows.Input.ICommand RemoveAllFromCartCommand { get; private set; }
        public System.Windows.Input.ICommand CheckoutCommand { get; private set; }

        public ObservableCollection<FoodViewModel> Foods { get; private set; }
        public ObservableCollection<FoodViewModel> LineItems { get; private set; }

        public ShoppingCartViewModel(
            IShoppingCartRepository shoppingCartRepository, 
            IFoodRepository foodRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _foodRepository = foodRepository;
        }

        public void InitializeViewModel()
        {
            var removeAllFromCartCommand 
                = new RemoveAllFromCartCommand(_shoppingCartRepository, _foodRepository);

            RemoveAllFromCartCommand = new RelayCommand(
                    execute: () =>
                    {
                        removeAllFromCartCommand.Execute();

                        Refresh();
                    }, 
                    canExecute:() => removeAllFromCartCommand.CanExecute()
                );

            CheckoutCommand = new RelayCommand(
                    execute:() => {
                        var total = LineItems.Sum(x => x.Food.Price * x.Quantity);
                        MessageBox.Show($"Shopping cart total: ${total}");
                    },
                    canExecute:() => LineItems.Any()
                );

            Refresh();
        }

        public void Refresh()
        {
            var foods = _foodRepository
                .All()
                .Select(food => new FoodViewModel(this,
                                        _shoppingCartRepository,
                                        _foodRepository,
                                        food));

            var lineItems = _shoppingCartRepository
                .All()
                .Select(x => new FoodViewModel(this, 
                                    _shoppingCartRepository, 
                                    _foodRepository, 
                                    x.Food, 
                                    x.Quantity));

            Foods = new ObservableCollection<FoodViewModel>(foods);
            LineItems = new ObservableCollection<FoodViewModel>(lineItems);

            OnPropertyRaised(nameof(Foods));
            OnPropertyRaised(nameof(LineItems));
        }
    }
}
