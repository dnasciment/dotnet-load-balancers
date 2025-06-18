using RoundRobinBalancer;

var servers = new List<Server>
{
    new("Server-A"),
    new("Server-B"),
    new("Server-C")
};

ILoadBalancer<Server> loadBalancer = new RoundRobinLoadBalancer<Server>(servers);

Console.WriteLine("Round Robin Load Balancer Simulation");
Console.WriteLine("------------------------------------");

for (var i = 1; i <= 20; i++)
{
    var selected = loadBalancer.GetNext();
    Console.WriteLine($"[REQ {i}] Sent to: {selected}");
    Thread.Sleep(300);
}