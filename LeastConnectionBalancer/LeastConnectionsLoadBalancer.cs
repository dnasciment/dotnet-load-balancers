namespace LeastConnectionBalancer
{
    public class LeastConnectionsLoadBalancer : ILoadBalancer<Server>
    {
        private readonly IList<Server> _servers;

        public LeastConnectionsLoadBalancer(IEnumerable<Server> servers)
        {
            _servers = servers.ToList();
        }

        public Server GetNext()
        {
            return _servers.OrderBy(s => s.ActiveConnections).First();
        }
    }
}