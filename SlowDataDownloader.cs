

public class SlowDataDownloader : IDataDownloader
{

    public string DownloadData(string resourcId)
    {
        Thread.Sleep(3000);
        return $"Some data for {resourcId}.";
    }
}
