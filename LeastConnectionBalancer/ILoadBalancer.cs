namespace LeastConnectionBalancer
{
    public interface ILoadBalancer<T>
    {
        T GetNext();
    }
}