using EONET_Fetcher.Interfaces;

namespace EONET_Fetcher.Models
{
    public class EventSource : IEventSource
    {
        public string Id { get; set; }

        public string Url { get; set; }
    }
}
