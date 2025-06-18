using IPHashBalancer;

var servers = new List<Server>
{
    new("Server-1"),
    new("Server-2"),
    new("Server-3")
};

ILoadBalancer<Server> loadBalancer = new IpHashLoadBalancer(servers);

Console.WriteLine("IP Hash Load Balancer Simulation");
Console.WriteLine("--------------------------------");

var clientIps = new[]
{
    "192.168.0.1",
    "192.168.0.2",
    "192.168.0.3",
    "10.0.0.5",
    "172.16.1.1",
    "192.168.0.1", // repeat
    "10.0.0.5"
};

var serverHits = new Dictionary<string, int>();
var ipToServer = new Dictionary<string, string>();

foreach (var ip in clientIps)
{
    var server = loadBalancer.GetNext(ip);
    Console.WriteLine($"Client IP: {ip} => Routed to: {server}");

    ipToServer[ip] = server.Name;
    serverHits.TryGetValue(server.Name, out var count);
    serverHits[server.Name] = count + 1;
}

Console.WriteLine();
Console.WriteLine("=== Final Statistics ===");

foreach (var server in servers)
{
    serverHits.TryGetValue(server.Name, out var hits);
    var percent = (double)hits / clientIps.Length * 100;
    Console.WriteLine($"{server.Name} handled {hits} requests ({percent:F1}%)");
}

Console.WriteLine("\n=== IP to Server Mapping ===");
foreach (var kvp in ipToServer.DistinctBy(x => x.Key))
{
    Console.WriteLine($"{kvp.Key} → {kvp.Value}");
}