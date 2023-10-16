

public class CachingDataDownloader : IDataDownloader
{
    private readonly IDataDownloader _dataDownloader;
    private readonly ICustomCache<string, string> _customCache;

    public CachingDataDownloader(IDataDownloader dataDownloader, ICustomCache<string, string> customCache)
    {
        _dataDownloader = dataDownloader;
        _customCache = customCache;
    }

    public string DownloadData(string resourceId) => _customCache.Get(resourceId, _dataDownloader.DownloadData);
}
