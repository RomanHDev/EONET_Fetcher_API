using System;

namespace EONET_Fetcher.Interfaces
{
    public interface IEventGeometry
    {
        float[] Coordinates { get; set; }
        DateTime Date { get; set; }
        string Type { get; set; }
    }
}