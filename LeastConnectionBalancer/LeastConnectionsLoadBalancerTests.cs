using Xunit;

namespace LeastConnectionBalancer
{
    public class LeastConnectionsLoadBalancerTests
    {
        [Fact]
        public void Should_Select_Server_With_Least_Connections()
        {
            var server1 = new Server("S1");
            var server2 = new Server("S2");
            var server3 = new Server("S3");

            server1.Connect();
            server2.Connect();
            server2.Connect();

            var balancer = new LeastConnectionsLoadBalancer(new[] { server1, server2, server3 });

            var selected = balancer.GetNext();

            Assert.Equal("S3", selected.Name);
        }
    }
}