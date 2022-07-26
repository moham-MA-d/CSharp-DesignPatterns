using Chain_Of_Responsibility.Exceptions;
using Chain_Of_Responsibility.Models;

namespace Chain_Of_Responsibility.Handlers
{
    public class RestaurantHandler
    {
        private readonly IList<IReceiver<Order>> _receivers;

        public RestaurantHandler(params IReceiver<Order>[] receivers)
        {
            _receivers = receivers;
        }

        public void RestaurantHandle(Order order)
        {
            foreach (var receiver in _receivers)
            {
                receiver.RestaurantHandle(order);
            }
        }
        public void Handle(Order order)
        {
            foreach (var receiver in _receivers)
            {
                if (order.OrderedFoods.Any(x => x.IsPaid == false))
                {
                    receiver.Handle(order);
                }
                else
                {
                    break;
                }
            }
            if (order.Paid < 1)
            {
                throw new InsufficientPaymentException();
            }
            else
            {
                order.DeliveryStatus = DeliveryStatus.ReadyToDeliver;
            }
        }
    }
}
