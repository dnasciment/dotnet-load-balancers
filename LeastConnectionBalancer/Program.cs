using LeastConnectionBalancer;

var servers = new List<Server>
{
    new("Server-1"),
    new("Server-2"),
    new("Server-3")
};

ILoadBalancer<Server> loadBalancer = new LeastConnectionsLoadBalancer(servers);

Console.WriteLine("Least Connections Load Balancer Simulation");
Console.WriteLine("-----------------------------------------");

var random = new Random();

for (int i = 1; i <= 20; i++)
{
    var selected = loadBalancer.GetNext();
    selected.Connect();

    Console.WriteLine($"[REQ {i}] Routed to: {selected}");

    _ = Task.Run(async () =>
    {
        await Task.Delay(random.Next(500, 1500));
        selected.Disconnect();
    });

    await Task.Delay(300);
}

await Task.Delay(3000);

Console.WriteLine();
Console.WriteLine("=== Final Statistics ===");
foreach (var server in servers)
{
    Console.WriteLine($"{server.Name} => {server.TotalRequests} requests");
}
