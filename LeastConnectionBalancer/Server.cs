namespace LeastConnectionBalancer
{
    public class Server
    {
        public string Name { get; }
        private int _activeConnections;
        private int _totalRequests;

        public Server(string name)
        {
            Name = name;
            _activeConnections = 0;
            _totalRequests = 0;
        }

        public int ActiveConnections => _activeConnections;
        public int TotalRequests => _totalRequests;

        public void Connect()
        {
            Interlocked.Increment(ref _activeConnections);
            Interlocked.Increment(ref _totalRequests);
        }

        public void Disconnect()
        {
            Interlocked.Decrement(ref _activeConnections);
        }

        public override string ToString() =>
            $"{Name} (Active: {_activeConnections}, Total: {_totalRequests})";
    }
}