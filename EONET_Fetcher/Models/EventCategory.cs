using EONET_Fetcher.Interfaces;

namespace EONET_Fetcher.Models
{
    public class EventCategory : IEventCategory
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
