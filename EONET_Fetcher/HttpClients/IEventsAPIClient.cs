using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EONET_Fetcher.HttpClients
{
    public interface IEventsAPIClient
    {
        Task<HttpResponseMessage> GetEventsAsync(Uri uri, HttpCompletionOption completionOption);
    }
}