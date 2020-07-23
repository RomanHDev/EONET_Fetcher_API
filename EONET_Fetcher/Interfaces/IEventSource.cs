namespace EONET_Fetcher.Interfaces
{
    public interface IEventSource
    {
        string Id { get; set; }
        string Url { get; set; }
    }
}