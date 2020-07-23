using System.Collections.Generic;

namespace EONET_Fetcher.Interfaces
{
    public interface IEventsListEONET
    {
        string Description { get; set; }
        List<IEventEONET> Events { get; set; }
        string Link { get; set; }
        string Title { get; set; }
    }
}