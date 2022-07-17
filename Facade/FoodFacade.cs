using Facade.Models;
using Facade.Services;

namespace Facade
{
    public class FoodFacade : IFoodFacade
    {
        private readonly CookService _cookService;
        private readonly DetailService _detailService;
        private readonly PaymentService _paymentService;

        public FoodFacade() : 
            this(new CookService(), new DetailService(), new PaymentService())
        {
            
        }

        private FoodFacade(CookService cookService,
                                DetailService detailService,
                                PaymentService paymentService)
        {
            _cookService = cookService;
            _detailService = detailService;
            _paymentService = paymentService;
        }

        public FoodOrderResult GetFood(string foodName, string drinkName)
        {
            _detailService.Provide(drinkName);
            _cookService.Bake(80);
            
            var price = _paymentService.GetPrice(foodName);

            var results = new FoodOrderResult
            {
                Name = foodName,
                Price =  price,
                Drink = drinkName
            };
            
            return results;
        }
    }
}