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





As there is a polygon category with 3 dimensional array:

Json deserializer has some problems with this event property :
"coordinates": [ -111.145, 31.992000000000001 ]
unexpected character

JsonReaderException: Unexpected character encountered while parsing value: [. Path 'events[111].geometries[0].coordinates', line 4241, position 22.


"id": "EONET_354",
			"title": "Dukono Volcano, Indonesia",
            "description": "During 16 and 19-22 March, ash plumes from Dukono rose to altitudes of 1.5-2.4 km (5,000-8,000 ft).",
			"link": "https://eonet.sci.gsfc.nasa.gov/api/v2.1/events/EONET_354",
			"categories": [
				{
					"id": 12,
					"title": "Volcanoes"
				}
			],
			"sources": [
				{
					"id": "EO",
					"url": "http://earthobservatory.nasa.gov/NaturalHazards/view.php?id=87762"
				},
				{
					"id": "SIVolcano",
					"url": "http://volcano.si.edu/volcano.cfm?vn=268010"
				}
			
			],
			"geometries": [
				{
					"date": "2016-03-16T00:00:00Z",
					"type": "Polygon", 
					"coordinates": [[ [127.84286499023438, 1.6633016286241373], [127.84286499023438, 1.7379700300000804], [127.91641235351562, 1.7379700300000804], [127.91641235351562, 1.6633016286241373], [127.84286499023438, 1.6633016286241373] ]]
				}
			
			]
		}