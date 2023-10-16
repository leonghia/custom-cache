

public class MemoryCache<TKey, TValue> : ICustomCache<TKey, TValue>
{
    private static readonly IDictionary<TKey, TValue> _data = new Dictionary<TKey, TValue>();
    public TValue Get(TKey resourceId, Func<TKey, TValue> predicate)
    {
        if (!_data.ContainsKey(resourceId)) _data.Add(resourceId, predicate(resourceId));
        return _data[resourceId];
    }
}