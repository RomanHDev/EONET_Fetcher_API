Full query string (change your port):

https://localhost:44303/api/events?limit=50&days=200&source=InciWeb,EO&status=open&searchString=fire&filterBy=title&sortBy=id&sortOrder=asc

status (default open): open | closed
filterBy (empty or):  description | title | link | category | source
sortBy: asc | desc


https://localhost:44303/api/events/EONET_4776?searchString=fire&filterBy=category&sortBy=category&sortOrder=asc

filterBy (empty or):  category | geometry | source
sortBy: asc | desc



https://eonet.sci.gsfc.nasa.gov/docs/v2.1#eventsAPI
Usage Example:
https://eonet.sci.gsfc.nasa.gov/api/v2.1/events?limit=50&days=365