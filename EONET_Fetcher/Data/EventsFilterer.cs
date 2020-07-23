using EONET_Fetcher.Interfaces;
using EONET_Fetcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EONET_Fetcher.Data
{
    public class EventsFilterer// : IEventsFilterer
    {
        public void Filter(string searchString, string filterBy, EventsListEONET eventsListEONET)
        {
            var eventsList = new List<EventEONET>();
            if (filterBy != null)
            {
                var eventsFilterer = new EventsFilterer();
                var tmpEventsList = FilterBy(searchString.ToLower(), filterBy.ToLower(), eventsListEONET, eventsList);
                eventsList = tmpEventsList;
            }
            else
            {
                eventsList = eventsListEONET.Events.Where(e => e.Description.Contains(searchString) == true |
                                                                e.Title.Contains(searchString) == true |
                                                                e.Link.Contains(searchString) == true |
                                                                e.Categories.Any(c => c.Title.Contains(searchString)) == true |
                                                                e.Sources.Any(c => c.Url.Contains(searchString) == true)).ToList();

            }
            if (eventsList != null || eventsList.Count > 0)
            {
                eventsListEONET.Events = eventsList;
            }
        }

        private List<EventEONET> FilterBy(string searchString, string filterBy, EventsListEONET eventsListEONET, List<EventEONET> eventsList)
        {
            if (filterBy.ToLower() == "description")
            {
                eventsList = eventsListEONET.Events.Where(e => e.Description.ToLower().Contains(searchString)).ToList();
            }
            else if (filterBy.ToLower() == "title")
            {
                eventsList = eventsListEONET.Events.Where(e => e.Title.ToLower().Contains(searchString)).ToList();
                //var tmpeventsList = eventsListEONET.Events.Where(e => e.Title.ToLower().Contains(searchString)).ToList();
                //tmpeventsList = tmpeventsList;
            }
            else if (filterBy.ToLower() == "link")
            {
                eventsList = eventsListEONET.Events.Where(e => e.Title.ToLower().Contains(searchString)).ToList();
            }
            else if (filterBy.ToLower() == "category")
            {
                eventsList = eventsListEONET.Events.Where(e => e.Categories.Any(c => c.Title.ToLower().Contains(searchString))).ToList();
            }
            else if (filterBy.ToLower() == "sources")
            {
                eventsList = eventsListEONET.Events.Where(e => e.Sources.Any(c => c.Url.ToLower().Contains(searchString))).ToList();
            }

            return eventsList;
        }


    }
}
