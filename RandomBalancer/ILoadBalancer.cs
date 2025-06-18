namespace RandomBalancer
{
    public interface ILoadBalancer<T>
    {
        T GetNext();
    }
}