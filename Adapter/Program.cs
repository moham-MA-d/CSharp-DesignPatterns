using Adapter.Adapter;
using Adapter.Repository;
using Adapter.Service;

Console.WriteLine("====================Foods From File====================");
const string filename = @"../../../../Adapter/Foods.json";
var fileService = new FoodService(new FoodAdapterFile(filename, new FoodRepositoryFile()));
Console.WriteLine(fileService.ListCharacters());

Console.WriteLine("====================Foods From Database====================");
var dbService = new FoodService(new FoodAdapterDb(new FoodRepositoryDb()));
Console.WriteLine(dbService.ListCharacters());
