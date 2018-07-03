create database Tour_DB; # create DB
use Tour_DB; # Select the DB in use

create table TRIP
(
	TRIP_ID int primary key, # trip id is a number, and a number in SQL is an int
	TRIP_NAME varchar(50),
	START_LOCATION varchar(50),
	STATE char(2),
	DISTANCE int,
	MAX_GRP_SIZE int,
	TYPE varchar(20),
	SEASON varchar(20));

insert into TRIP values( 1,	'Arethusa Falls',	'Harts Location', 'NH',	5,	10,	'Hiking', 'Summer' );
insert into TRIP values( 2,	'Mt Ascutney - North Peak',	'Weathersfield',	'VT',	5,	6,	'Hiking', 'Late Spring' );
insert into TRIP values( 3,	'Mt Ascutney - West Peak',	'Weathersfield',	'VT',	6,	10,	'Hiking', 'Early Fall' );
insert into TRIP values( 4,	'Bradbury Mountain Ride', 'Lewiston-Auburn',	'ME',	25,	8,	'Biking', 'Early Fall' );
insert into TRIP values( 5,	'Baldpate Mountain',	'North Newry',	'ME',	6,	10,	'Hiking', 'Late Spring' );
insert into TRIP values( 6,	'Blueberry Mountain', 'Batchelders Grant',	'ME',	8,	8,	'Hiking', 'Early Fall' );
insert into TRIP values( 7,	'Bloomfield - Maidstone', 'Bloomfield',	'CT',	10,	6,	'Paddling', 'Late Spring' );
insert into TRIP values( 8,	'Black Pond', 'Lincoln', 'NH', 8, 12, 'Hiking', 'Summer' );
insert into TRIP values( 9,	'Big Rock Cave', 'Tamworth', 'NH', 6, 10, 'Hiking', 'Summer' );
insert into TRIP values( 10, 'Mt. Cardigan - Firescrew', 'Orange',	'NH', 7,	8,	'Hiking', 'Summer' );
insert into TRIP values( 11, 'Chocorua Lake Tour', 'Tamworth', 'NH', 12, 15, 'Paddling', 'Summer' );
insert into TRIP values( 12, 'Cadillac Mountain Ride',	'Bar Harbor', 'ME',	8,	16,	'Biking', 'Early Fall' );
insert into TRIP values( 13, 'Cadillac Mountain',	'Bar Harbor',	'ME',	7,	8,	'Hiking', 'Late Spring' );
insert into TRIP values( 14,	'Cannon Mtn', 'Franconia',	'NH',	6,	6,	'Hiking', 'Early Fall' );
insert into TRIP values( 15,	'Crawford Path Presidentials Hike',	'Crawford Notch',	'NH',	16,	4,	'Hiking', 'Summer' );
insert into TRIP values( 16,	'Cherry Pond', 'Whitefield',	'NH',	6,	16,	'Hiking', 'Spring' );
insert into TRIP values( 17,	'Huguenot Head Hike',	'Bar Harbor',	'ME',	5,	10,	'Hiking', 'Early Fall' );
insert into TRIP values( 18,	'Low Bald Spot Hike',	'Pinkam Notch',	'NH',	8,	6,	'Hiking',	'Early Fall' );
insert into TRIP values( 19,	'Mason''s Farm', 'North Stratford',	'CT',	12,	7,	'Paddling',	'Late Spring' );
insert into TRIP values( 20,	'Lake Mephremagog Tour', 'Newport',	'VT',	8,	15,	'Paddling',	'Late Spring' );
insert into TRIP values( 21,	'Long Pond', 'Rutland',	'MA',	8,	12,	'Hiking',	'Summer' );
insert into TRIP values( 22,	'Long Pond Tour',	'Greenville',	'ME',	12,	10,	'Paddling',	'Summer' );
insert into TRIP values( 23,	'Lower Pond Tour',	'Poland',	'ME',	8,	15,	'Paddling',	'Late Spring' );
insert into TRIP values( 24,	'Mt Adams', 'Randolph',	'NH',	9,	6,	'Hiking',	'Summer' );
insert into TRIP values( 25,	'Mount Battie Ride', 'Camden',	'ME',	20,	8,	'Biking',	'Early Fall' );
insert into TRIP values( 26,	'Mount Cardigan Hike', 'Cardigan',	'NH',	4,	16,	'Hiking',	'Late Fall' );
insert into TRIP values( 27,	'Mt. Chocorua', 'Albany',	'NH',	6,	10,	'Hiking',	'Spring' );
insert into TRIP values( 28,	'Mount Garfield Hike',	'Woodstock',	'NH',	5,	10,	'Hiking',	'Early Fall' );
insert into TRIP values( 29,	'Metacomet-Monadnock Trail Hike',	'Pelham',	'MA',	10,	12,	'Hiking',	'Late Spring' );
insert into TRIP values( 30,	'McLennan Reservation Hike',	'Tyringham',	'MA',	6,	16,	'Hiking',	'Summer' );
insert into TRIP values( 31,	'Missisquoi River - VT',	'Lowell',	'VT',	12,	10,	'Paddling',	'Summer' );
insert into TRIP values( 32,	'Northern Forest Canoe Trail',	'Stark',	'NH',	15,	10,	'Paddling',	'Summer' );
insert into TRIP values( 33,	'Park Loop Ride',	'Mount Desert Island',	'ME',	27,	8,	'Biking',	'Late Spring' );
insert into TRIP values( 34,	'Pontook Reservoir Tour',	'Dummer',	'NH',	15,	14,	'Paddling',	'Late Spring' );
insert into TRIP values( 35,	'Pisgah STATE Park Ride',	'Northborough',	'NH',	12,	10,	'Biking',	'Summer' );
insert into TRIP values( 36,	'Pondicherry Trail Ride',	'White Mountains',	'NH',	15,	16,	'Biking',	'Late Spring' );
insert into TRIP values( 37,	'Seal Beach Harbor',	'Bar Harbor',	'ME',	5,	16,	'Hiking',	'Early Spring' );
insert into TRIP values( 38,	'Sawyer River Ride',	'Mount Carrigain',	'NH',	10,	18,	'Biking',	'Early Fall' );
insert into TRIP values( 39,	'Welch and Dickey Mountains Hike',	'Thorton',	'NH',	5,	10,	'Hiking',	'Summer' );
insert into TRIP values( 40,	'Wachusett Mountain',	'Princeton',	'MA',	8,	8,	'Hiking',	'Early Spring' );
insert into TRIP values( 41,	'Westfield River Loop',	'Fort Fairfield',	'ME',	20,	10,	'Biking',	'Late Spring' );
