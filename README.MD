Full query string (change your port):

https://localhost:44303/api/events?limit=50&days=200&source=InciWeb,EO&status=open&searchString=fire&filterBy=title&sortBy=id&sortOrder=asc

status (default open): open | closed
filterBy (empty or):  description | title | link | category | source
sortBy: asc | desc


Here is known Bug (look few lines down):
https://localhost:44303/api/events?id=EONET_4776&searchString=fire&filterBy=category&sortBy=category&sortOrder=asc

filterBy (empty or):  category | geometry | source
sortBy: asc | desc



https://eonet.sci.gsfc.nasa.gov/docs/v2.1#eventsAPI
Usage Example:
https://eonet.sci.gsfc.nasa.gov/api/v2.1/events?limit=50&days=365






Json deserializer has some problems with this event property :
"coordinates": [ -111.145, 31.992000000000001 ]
unexpected character

JsonReaderException: Unexpected character encountered while parsing value: [. Path 'events[111].geometries[0].coordinates', line 4241, position 22.


"id": "EONET_4750",
			"title": "Navarro Fire",
            "description": "",
			"link": "https://eonet.sci.gsfc.nasa.gov/api/v2.1/events/EONET_4750",
			"categories": [
				{
					"id": 8,
					"title": "Wildfires"
				}
			],
			"sources": [
				{
					"id": "InciWeb",
					"url": "http://inciweb.nwcg.gov/incident/6848/"
				}
			
			],
			"geometries": [
				{
					"date": "2020-07-11T22:00:00Z",
					"type": "Point", 
					"coordinates": [ -111.145, 31.992000000000001 ]
				}
			
			]