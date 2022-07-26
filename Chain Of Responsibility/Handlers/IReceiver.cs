namespace Chain_Of_Responsibility.Handlers
{
    public interface IReceiver<in T> where T : class
    {
        void Handle(T order);
        void RestaurantHandle(T order);
    }
}
