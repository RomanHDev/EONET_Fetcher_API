using System;
using System.Collections.Generic;

namespace EONET_Fetcher.Interfaces
{
    public interface IEventGeometry
    {
        List<Object> Coordinates { get; set; }
        DateTime Date { get; set; }
        string Type { get; set; }
    }
}