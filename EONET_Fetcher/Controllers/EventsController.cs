using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EONET_Fetcher.Data;
using EONET_Fetcher.Models;
using System.Net.Http;
using EONET_Fetcher.Interfaces;
using System.IO;
using EONET_Fetcher.HttpClients;
using Newtonsoft.Json;

namespace EONET_Fetcher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventsAPIClient _httpClient;
        private string _sourceUrl;
        private string _eventsUrlKey;

        public EventsController(IEventsAPIClient httpClient, IUrlRootResolver urlRootResolver) //IEventsAPIClient httpClient, 
        {
            _httpClient = httpClient;
            _sourceUrl = urlRootResolver.GetSourceUrl();
            _eventsUrlKey = urlRootResolver.GetEventsUrlKey();
        }

        // GET: api/Events/
        [HttpGet]
        public async Task<ActionResult> GetEventsListEONET([FromQuery] string limit, [FromQuery] string days, [FromQuery] string[] source,
            [FromQuery] string status, [FromQuery] string sortBy, [FromQuery] string sortOrder, [FromQuery] string searchString, [FromQuery] string filterBy)
        {
            var urlsResolver = new UrlsResolver();
            var requestUri = urlsResolver.FormatRequestUri(_sourceUrl,_eventsUrlKey,limit,days,source,status);

            var httpResponse = await _httpClient.GetEventsAsync(requestUri, HttpCompletionOption.ResponseHeadersRead);

            httpResponse.EnsureSuccessStatusCode();
            var eventsListEONET = new EventsListEONET();
            if (httpResponse.Content is object && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
            {
                //var contentStream = await httpResponse.Content.ReadAsStreamAsync();
                //var json = await httpResponse.Content.ReadAsStringAsync();
                
                try
                {
                    var contentStream = await httpResponse.Content.ReadAsStreamAsync();

                    using var streamReader = new StreamReader(contentStream);
                    using var jsonReader = new JsonTextReader(streamReader);

                    JsonSerializer serializer = new JsonSerializer();

                    eventsListEONET = serializer.Deserialize<EventsListEONET>(jsonReader);
                    
                }
                catch (JsonException) // Invalid JSON
                {
                    return NotFound("Invalid JSON.");
                }
                catch (Exception)
                {
                    return NotFound();
                }
            }

            if (eventsListEONET == null)
            {
                return NotFound();
            }
            if (searchString != null)
            {
                var filterer = new EventsFilterer();
                filterer.Filter(searchString, filterBy, eventsListEONET);
            }
            if (sortBy != null && sortOrder != null)
            {
                var eventsSorter = new EventsSorter();
                eventsSorter.Sort(eventsListEONET,sortOrder,sortBy);
            }

            return Ok(JsonConvert.SerializeObject(eventsListEONET, Formatting.Indented));
        }
    }
}
