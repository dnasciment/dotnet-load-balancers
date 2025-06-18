namespace IPHashBalancer
{
    public interface ILoadBalancer<T>
    {
        T GetNext(string key);
    }
}