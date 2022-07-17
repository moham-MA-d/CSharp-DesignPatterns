using System;
using System.Net.Mail;

namespace Facade.Services
{
    public class CookService
    {
        public void Bake(int temp)
        {
            Console.WriteLine($"Baking has started at temperature {temp}");
        }
    }
}