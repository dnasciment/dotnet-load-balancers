using Xunit;

namespace RoundRobinBalancer;

public class RoundRobinLoadBalancerTests
{
    [Fact]
    public void Should_Distribute_Requests_Sequentially()
    {
        var servers = new[] { "A", "B", "C" };
        var balancer = new RoundRobinLoadBalancer<string>(servers);

        Assert.Equal("A", balancer.GetNext());
        Assert.Equal("B", balancer.GetNext());
        Assert.Equal("C", balancer.GetNext());
        Assert.Equal("A", balancer.GetNext());
    }
}