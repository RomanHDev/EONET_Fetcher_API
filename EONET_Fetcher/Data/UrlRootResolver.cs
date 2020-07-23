using EONET_Fetcher.Interfaces;
using Microsoft.Extensions.Configuration;

namespace EONET_Fetcher.Data
{
    public class UrlRootResolver : IUrlRootResolver
    {
        private readonly IConfiguration _configuration;

        public UrlRootResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetSourceUrl()
        {
            return _configuration.GetValue<string>("SourcesUrl");
        }

        public string GetEventsUrlKey()
        {
            return _configuration.GetValue<string>("EventsUrlKey");
        }        
    }
}
