namespace Facade.Models
{
    public class Address
    {
        public Address GetCityForZipCode(string zipCode)
        {
            // service or db lookup would go here
            return new Address();
        }

        public string Name => "Redmond";
    }
}