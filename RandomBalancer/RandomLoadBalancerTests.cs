using Xunit;

namespace RandomBalancer
{
    public class RandomLoadBalancerTests
    {
        [Fact]
        public void Should_Return_A_Server()
        {
            var servers = new[]
            {
            new Server("X"),
            new Server("Y"),
            new Server("Z")
        };

            var balancer = new RandomLoadBalancer(servers);

            var selected = balancer.GetNext();

            Assert.Contains(selected, servers);
        }

        [Fact]
        public void Should_Eventually_Distribute_To_All_Servers()
        {
            var servers = new[]
            {
            new Server("X"),
            new Server("Y"),
            new Server("Z")
        };

            var balancer = new RandomLoadBalancer(servers);
            var hits = new HashSet<string>();

            for (int i = 0; i < 100; i++)
            {
                var selected = balancer.GetNext();
                hits.Add(selected.Name);
            }

            Assert.Equal(servers.Length, hits.Count);
        }
    }
}