namespace EONET_Fetcher.Interfaces
{
    public interface IEventsSorter
    {
        void Sort(IEventsListEONET eventsListEONET, string sortOrder, string sortBy);
        void SortEvent(IEventEONET eventEONET, string sortOrder, string sortBy);
    }
}