using EONET_Fetcher.Interfaces;
using EONET_Fetcher.Models;
using System;
using System.Linq;

namespace EONET_Fetcher.Data
{
    public class EventsSorter// : IEventsSorter
    {
        public void Sort(EventsListEONET eventsListEONET, string sortOrder, string sortBy)
        {
            if (sortOrder.ToLower() == "asc")
            {
                SortAsc(eventsListEONET, sortBy);
            }
            else if (sortOrder.ToLower() == "desc")
            {
                SortDesc(eventsListEONET, sortBy);
            }
        }

        public void SortEvent(EventEONET eventEONET, string sortOrder, string sortBy)
        {
            if (sortOrder.ToLower() == "asc")
            {
                SortEventAsc(eventEONET, sortBy);
            }
            else if (sortOrder.ToLower() == "desc")
            {
                SortEventDesc(eventEONET, sortBy);
            }
        }

        private void SortEventDesc(EventEONET eventEONET, string sortBy)
        {
            if (sortBy.ToLower() == "category")
            {
                eventEONET.Categories = eventEONET.Categories.OrderByDescending(e => e.Title).ToList();
            }
            else if (sortBy.ToLower() == "geometry")
            {
                eventEONET.Geometries = eventEONET.Geometries.OrderByDescending(e => e.Date).ToList();
            }
            else if (sortBy.ToLower() == "source")
            {
                eventEONET.Sources = eventEONET.Sources.OrderByDescending(e => e.Url).ToList();
            }
        }

        private void SortEventAsc(EventEONET eventEONET, string sortBy)
        {
            if (sortBy.ToLower() == "category")
            {
                eventEONET.Categories = eventEONET.Categories.OrderBy(e => e.Title).ToList();
            }
            else if (sortBy.ToLower() == "geometry")
            {
                eventEONET.Geometries = eventEONET.Geometries.OrderBy(e => e.Date).ToList();
            }
            else if (sortBy.ToLower() == "source")
            {
                eventEONET.Sources = eventEONET.Sources.OrderBy(e => e.Url).ToList();
            }
        }

        private void SortDesc(EventsListEONET eventsListEONET, string sortBy)
        {
            if (sortBy.ToLower() == "title")
            {
                eventsListEONET.Events = eventsListEONET.Events.OrderByDescending(e => e.Title).ToList();
            }
            else if (sortBy.ToLower() == "description")
            {
                eventsListEONET.Events = eventsListEONET.Events.OrderByDescending(e => e.Description).ToList();
            }
            else if (sortBy.ToLower() == "id")
            {
                eventsListEONET.Events = eventsListEONET.Events.OrderByDescending(e => e.Id).ToList();
            }
            else if (sortBy.ToLower() == "link")
            {
                eventsListEONET.Events = eventsListEONET.Events.OrderByDescending(e => e.Link).ToList();
            }
        }

        private void SortAsc(EventsListEONET eventsListEONET, string sortBy)
        {
            if (sortBy.ToLower() == "title")
            {
                eventsListEONET.Events = eventsListEONET.Events.OrderBy(e => e.Title).ToList();
            }
            else if (sortBy.ToLower() == "description")
            {
                eventsListEONET.Events = eventsListEONET.Events.OrderBy(e => e.Description).ToList();
            }
            else if (sortBy.ToLower() == "id")
            {
                eventsListEONET.Events = eventsListEONET.Events.OrderBy(e => e.Id).ToList();
            }
            else if (sortBy.ToLower() == "link")
            {
                eventsListEONET.Events = eventsListEONET.Events.OrderBy(e => e.Link).ToList();
            }
        }
    }
}
