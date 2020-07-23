namespace EONET_Fetcher.Interfaces
{
    public interface IEventsFilterer
    {
        void Filter(string searchString, string filterBy, IEventsListEONET eventsListEONET);
        void FilterEvent(string searchString, string filterBy, IEventEONET eventEONET);
    }
}