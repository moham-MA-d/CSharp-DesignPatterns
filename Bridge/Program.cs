using Bridge.Models;
using Bridge.Repository;

FoodRepository foodRepository = new ();

var kebabId = foodRepository.Order(Food.FoodEnum.Kebab, Food.OrderTypeEnum.DineIn);
foodRepository.Cook(kebabId, 20);

var pizzaId = foodRepository.Order(Food.FoodEnum.Pizza, Food.OrderTypeEnum.TakeAway);
foodRepository.Cook(pizzaId, 20);

foodRepository.Display();

