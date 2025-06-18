using Xunit;

namespace IPHashBalancer
{
    public class IpHashLoadBalancerTests
    {
        [Fact]
        public void Should_Always_Return_Same_Server_For_Same_IP()
        {
            var servers = new[]
            {
            new Server("A"),
            new Server("B"),
            new Server("C")
        };

            var balancer = new IpHashLoadBalancer(servers);

            var ip = "192.168.1.100";
            var first = balancer.GetNext(ip);
            var second = balancer.GetNext(ip);

            Assert.Equal(first, second);
        }

        [Fact]
        public void Should_Distribute_Different_IPs_To_Different_Servers()
        {
            var servers = new[]
            {
            new Server("A"),
            new Server("B"),
            new Server("C")
        };

            var balancer = new IpHashLoadBalancer(servers);

            var ip1 = "192.168.1.1";
            var ip2 = "10.0.0.2";

            var s1 = balancer.GetNext(ip1);
            var s2 = balancer.GetNext(ip2);

            Assert.NotEqual(s1, s2);
        }
    }
}