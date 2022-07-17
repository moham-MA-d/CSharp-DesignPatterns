using Facade.Models;

namespace Facade.Services
{
    public class DetailService
    {
        public void Provide(string drink)
        {
            Console.WriteLine($"Your food is providing with a {drink}");
        }
    }
}