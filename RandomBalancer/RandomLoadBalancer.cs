namespace RandomBalancer
{
    public class RandomLoadBalancer : ILoadBalancer<Server>
    {
        private readonly IList<Server> _servers;
        private readonly Random _random;

        public RandomLoadBalancer(IEnumerable<Server> servers)
        {
            _servers = servers.ToList();
            _random = new Random();
        }

        public Server GetNext()
        {
            var index = _random.Next(_servers.Count);
            return _servers[index];
        }
    }
}