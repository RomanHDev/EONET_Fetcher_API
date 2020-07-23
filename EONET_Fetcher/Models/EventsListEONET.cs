using EONET_Fetcher.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EONET_Fetcher.Models
{
    public class EventsListEONET//: IEventsListEONET
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public List<EventEONET> Events { get; set; }
    }
}
