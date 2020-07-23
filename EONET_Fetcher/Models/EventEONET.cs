using EONET_Fetcher.Interfaces;
using System.Collections.Generic;

namespace EONET_Fetcher.Models
{
    public class EventEONET//: IEventEONET
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public List<EventCategory> Categories { get; set; }

        public List<EventSource> Sources { get; set; }

        public List<EventGeometry> Geometries { get; set; }
    }
}
