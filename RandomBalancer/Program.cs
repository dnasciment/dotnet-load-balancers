using RandomBalancer;

var servers = new List<Server>
{
    new("Server-X"),
    new("Server-Y"),
    new("Server-Z")
};

ILoadBalancer<Server> loadBalancer = new RandomLoadBalancer(servers);

var serverHits = new Dictionary<string, int>();

Console.WriteLine("Random Load Balancer Simulation");
Console.WriteLine("-------------------------------");

for (int i = 1; i <= 20; i++)
{
    var selected = loadBalancer.GetNext();

    serverHits.TryGetValue(selected.Name, out var count);
    serverHits[selected.Name] = count + 1;

    Console.WriteLine($"[REQ {i}] Sent to: {selected}");
    Thread.Sleep(300);
}

Console.WriteLine();
Console.WriteLine("=== Final Statistics ===");

foreach (var server in servers)
{
    serverHits.TryGetValue(server.Name, out var hits);
    var percent = (double)hits / 20 * 100;
    Console.WriteLine($"{server.Name} handled {hits} requests ({percent:F1}%)");
}