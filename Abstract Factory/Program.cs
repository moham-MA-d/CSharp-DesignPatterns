using Abstract_Factory.Models;
using Abstract_Factory.Models.Base;

Console.WriteLine("====================Abstract Factory RestaurantA====================");
IRestaurant restaurantA = new RestaurantA();

var fastFoodA = restaurantA.GetFastFood();
Console.WriteLine(fastFoodA.GetFood() + "\n");

var traditionalFoodA = restaurantA.GetTraditionalFood();
Console.WriteLine(traditionalFoodA.GetFood() + "\n");



Console.WriteLine("====================Abstract Factory RestaurantB====================");
IRestaurant restaurantB = new RestaurantB();

var fastFoodB = restaurantB.GetFastFood();
Console.WriteLine(fastFoodB.GetFood() + "\n");

var traditionalFoodB = restaurantB.GetTraditionalFood();
Console.WriteLine(traditionalFoodB.GetFood() + "\n");