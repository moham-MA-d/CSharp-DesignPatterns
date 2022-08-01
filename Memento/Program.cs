using Memento;

var order = new Order();
var history = new OrderStateHistory();

Console.WriteLine("====================Memento Pattern====================");

order.CreateOrder("Pizza");
history.Push(order.CreateState());

order.CreateOrder("Kebab");
history.Push(order.CreateState());

order.CreateOrder("Sandwich");
history.Push(order.CreateState());

order.Undo(history.Pop());
order.Undo(history.Pop());

var lastOrder = order.GetOrder();
Console.WriteLine(lastOrder);

Console.ReadKey();


