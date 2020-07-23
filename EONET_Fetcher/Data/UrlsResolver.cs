using EONET_Fetcher.Interfaces;
using EONET_Fetcher.Models.Enums;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EONET_Fetcher.Data
{
    public class UrlsResolver : IUrlsResolver
    {
        public UrlsResolver() { }

        public Uri FormatRequestUri(string sourceUrl, string eventsUrlKey, string limit, string days, string[] source,
            string status)
        {
            var queryParams = new Dictionary<string, string>();
            FormatLimit(limit, queryParams);
            FormatDays(days, queryParams);
            FormatSource(source, queryParams);            
            FormatStatus(status, queryParams);
            Uri requestUri;
            if (queryParams.Count > 0)
            {
                requestUri = new Uri(QueryHelpers.AddQueryString(sourceUrl + "/" + eventsUrlKey, queryParams));
            }
            else
            {
                requestUri = new Uri(sourceUrl + "/" + eventsUrlKey);
            }

            return requestUri;
        }

        public void FormatDays(string days, IDictionary<string, string> queryParams)
        {
            if (days != null)
            {
                int number;
                bool isParsable = Int32.TryParse(days, out number);

                if (isParsable)
                    queryParams.Add("days", days);
            }
        }

        public void FormatStatus(string status, IDictionary<string, string> queryParams)
        {
            if (status.ToLower() != null)
            {
                var st = status.ToLower();
                var open = Enum.GetName(typeof(Status), Status.Open).ToLower();
                var closed = Enum.GetName(typeof(Status), Status.Closed).ToLower();
                if (st == open | st == closed)
                {
                    queryParams.Add("status", status);
                }
            }
        }

        public void FormatLimit(string limit, IDictionary<string, string> queryParams)
        {
            if (limit != null)
            {
                int number;
                bool isParsable = Int32.TryParse(limit, out number);

                if (isParsable)
                    queryParams.Add("limit", limit);
            }
        }

        public void FormatSource(string[] source, IDictionary<string, string> queryParams)
        {
            if (source != null)
            {
                var strb = new StringBuilder();
                strb.AppendJoin(',', source);
                queryParams.Add("source", strb.ToString());
            }
        }
    }
}
