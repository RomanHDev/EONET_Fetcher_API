namespace EONET_Fetcher.Interfaces
{
    public interface IEventsSorter
    {
        void Sort(IEventsListEONET eventsListEONET, string sortOrder, string sortBy);
    }
}