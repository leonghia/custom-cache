

public interface ICustomCache<TKey, TValue>
{
    TValue Get(TKey resourceId, Func<TKey, TValue> predicate); 
}
