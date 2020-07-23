using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EONET_Fetcher.HttpClients
{
    public class EventsAPIClient : IEventsAPIClient
    {
        HttpClient _httpClient;
        public EventsAPIClient(HttpClient httpClient)
        {
            this._httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<HttpResponseMessage> GetEventsAsync(Uri uri, HttpCompletionOption completionOption)
        {
            return await _httpClient.GetAsync(uri, completionOption);
        }
    }
}
