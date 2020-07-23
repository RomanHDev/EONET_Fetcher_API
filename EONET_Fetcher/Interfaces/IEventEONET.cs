using System.Collections.Generic;

namespace EONET_Fetcher.Interfaces
{
    public interface IEventEONET
    {
        List<IEventCategory> Categories { get; set; }
        string Description { get; set; }
        List<IEventGeometry> Geometries { get; set; }
        string Id { get; set; }
        string Link { get; set; }
        List<IEventSource> Sources { get; set; }
        string Title { get; set; }
    }
}