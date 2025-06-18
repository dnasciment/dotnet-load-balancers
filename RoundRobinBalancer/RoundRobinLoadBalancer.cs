namespace RoundRobinBalancer;

public class RoundRobinLoadBalancer<T> : ILoadBalancer<T>
{
    private readonly IList<T> _items;
    private int _currentIndex = -1;
    private readonly object _lock = new();

    public RoundRobinLoadBalancer(IEnumerable<T> items)
    {
        _items = items.ToList();
    }

    public T GetNext()
    {
        lock (_lock)
        {
            _currentIndex = (_currentIndex + 1) % _items.Count;
            return _items[_currentIndex];
        }
    }
}