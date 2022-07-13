
namespace Singleton;

public sealed class ApplicationUsers 
{
    private static volatile ApplicationUsers? _instance;
    private static readonly object SyncLock = new();

    private ApplicationUsers()
    {
    }

    public static ApplicationUsers? Instance
    {
        get
        {
            if (_instance is not null) return _instance;
            
            lock (SyncLock)
                if (_instance is null) _instance = new ApplicationUsers();
            
            return _instance;
        }
    }

    public int OnlineUsers { get; set; }
    public int OfflineUsers { get; set; }
}