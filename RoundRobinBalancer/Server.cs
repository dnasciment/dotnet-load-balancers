namespace RoundRobinBalancer;

public class Server
{
    public string Name { get; }

    public Server(string name)
    {
        Name = name;
    }

    public override string ToString() => Name;
}