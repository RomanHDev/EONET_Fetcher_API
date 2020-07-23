using System;
using System.Collections.Generic;

namespace EONET_Fetcher.Interfaces
{
    public interface IUrlsResolver
    {
        Uri FormatRequestUri(string sourceUrl, string eventsUrl, string limit, string days, string[] source,
            string status);
        void FormatStatus(string status, IDictionary<string, string> queryParams);
        void FormatLimit(string limit, IDictionary<string, string> queryParams);
        void FormatSource(string[] source, IDictionary<string, string> queryParams);
    }
}