using Singleton;

var first = ApplicationUsers.Instance;
var second = ApplicationUsers.Instance;

if (first != null && second != null)
{
    Console.WriteLine("====================Singleton====================");
    
    first.OnlineUsers = 100;
    first.OfflineUsers = 50;

    Console.WriteLine($"first object online users: {first.OnlineUsers} first object offline users: {first.OfflineUsers}");
    Console.WriteLine($"second object online users: {second.OnlineUsers} second object offline users: {second.OfflineUsers}\n ");
    
    
    Console.WriteLine("====================Singleton Second object changed====================");
    
    second.OnlineUsers = 200;
    second.OfflineUsers = 150;
    
    Console.WriteLine($"first object online users: {first.OnlineUsers} first object offline users: {first.OfflineUsers}");
    Console.WriteLine($"second object online users: {second.OnlineUsers} second object offline users: {second.OfflineUsers}\n ");

}