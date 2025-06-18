namespace RoundRobinBalancer;

public interface ILoadBalancer<out T>
{
    T GetNext();
}