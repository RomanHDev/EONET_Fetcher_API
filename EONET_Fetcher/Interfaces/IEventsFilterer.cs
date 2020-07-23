namespace EONET_Fetcher.Interfaces
{
    public interface IEventsFilterer
    {
        void Filter(string searchString, string filterBy, IEventsListEONET eventsListEONET);
    }
}