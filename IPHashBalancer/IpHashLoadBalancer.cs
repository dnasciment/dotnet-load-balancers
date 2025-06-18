using System.Security.Cryptography;
using System.Text;


namespace IPHashBalancer
{
    public class IpHashLoadBalancer : ILoadBalancer<Server>
    {
        private readonly IList<Server> _servers;

        public IpHashLoadBalancer(IEnumerable<Server> servers)
        {
            _servers = servers.ToList();
        }

        public Server GetNext(string ip)
        {
            var hash = GetStableHash(ip);
            var index = Math.Abs(hash) % _servers.Count;
            return _servers[index];
        }

        private int GetStableHash(string input)
        {
            using var sha256 = SHA256.Create();
            var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BitConverter.ToInt32(hashBytes, 0);
        }
    }
}