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
insert into TRIP values( 33,	'Park Loop Ride', 'Mount Desert Island',	'ME',	27,	8,	'Biking',	'Late Spring' );
insert into TRIP values( 34,	'Pontook Reservoir Tour',	'Dummer',	'NH',	15,	14,	'Paddling',	'Late Spring' );
insert into TRIP values( 35,	'Pisgah STATE Park Ride',	'Northborough',	'NH',	12,	10,	'Biking',	'Summer' );
insert into TRIP values( 36,	'Pondicherry Trail Ride',	'White Mountains',	'NH',	15,	16,	'Biking',	'Late Spring' );
insert into TRIP values( 37,	'Seal Beach Harbor',	'Bar Harbor',	'ME',	5,	16,	'Hiking',	'Early Spring' );
insert into TRIP values( 38,	'Sawyer River Ride',	'Mount Carrigain',	'NH',	10,	18,	'Biking',	'Early Fall' );
insert into TRIP values( 39,	'Welch and Dickey Mountains Hike',	'Thorton',	'NH',	5,	10,	'Hiking',	'Summer' );
insert into TRIP values( 40,	'Wachusett Mountain',	'Princeton',	'MA',	8,	8,	'Hiking',	'Early Spring' );
insert into TRIP values( 41,	'Westfield River Loop',	'Fort Fairfield',	'ME',	20,	10,	'Biking',	'Late Spring' );

CREATE TABLE RESERVATION
(
	RESERVATION_ID INT PRIMARY KEY,
	TRIP_ID INT,
	TRIP_DATE DATE,
	NUM_PERSONS INT,
	TRIP_PRICE INT,
	OTHER_FEES INT,
	CUSTOMER_NUM INT
);


insert into RESERVATION values( 1600001,	40,	'2016-03-26',	2,	55,	0,	101 );
insert into RESERVATION values( 1600002,	21,	'2016-06-08',	2,	95,	0,	101 );
insert into RESERVATION values( 1600003,	28,	'2016-09-12',	1,	35,	0,	103 );
insert into RESERVATION values( 1600004,	26,	'2016-10-16',	4,	45,	15,	104 );
insert into RESERVATION values( 1600005,	39,	'2016-06-25',	5,	55,	0,	105 );
insert into RESERVATION values( 1600006,	32,	'2016-06-18',	1,	80,	20,	106 );
insert into RESERVATION values( 1600007,	22,	'2016-07-09',	8,	75,	10,	107 );
insert into RESERVATION values( 1600008,	28,	'2016-09-12',	2,	35,	0,	108 );
insert into RESERVATION values( 1600009,	38,	'2016-09-11',	2,	90,	40,	109 );
insert into RESERVATION values( 1600010,	2,	'2016-05-14',	3,	25,	0,	102 );
insert into RESERVATION values( 1600011,	3,	'2016-09-15',	3,	25,	0,	102 );
insert into RESERVATION values( 1600012,	1,	'2016-06-12',	4,	15,	0,	115 );
insert into RESERVATION values( 1600013,	8,	'2016-07-09',	1,	20,	5,	116 );
insert into RESERVATION values( 1600014,	12,	'2016-10-01',	2,	40,	5,	119 );
insert into RESERVATION values( 1600015,	10,	'2016-07-23',	1,	20,	0,	120 );
insert into RESERVATION values( 1600016,	11,	'2016-07-23',	6,	75,	15,	121 );
insert into RESERVATION values( 1600017,	39,	'2016-06-18',	3,	20,	5,	122 );
insert into RESERVATION values( 1600018,	38,	'2016-09-18',	4,	85,	15,	126 );
insert into RESERVATION values( 1600019,	25,	'2016-08-29',	2,	110,	25,	124 );
insert into RESERVATION values( 1600020,	28,	'2016-08-27',	2,	35,	10,	124 );
insert into RESERVATION values( 1600021,	32,	'2016-06-11',	3,	90,	20,	112 );
insert into RESERVATION values( 1600022,	21,	'2016-06-08',	1,	95,	25,	119 );
insert into RESERVATION values( 1600024,	38,	'2016-09-11',	1,	70,	30,	121 );
insert into RESERVATION values( 1600025,	38,	'2016-09-11',	2,	70,	45,	125 );
insert into RESERVATION values( 1600026,	12,	'2016-10-01',	2,	40,	0,	126 );
insert into RESERVATION values( 1600029,	4,	'2016-09-19',	4,	105,	25,	120 );
insert into RESERVATION values( 1600030,	15,	'2016-07-25',	6,	60,	15,	104 );

create table trip_guides
(
	ASSOCIATION_ID int NOT NULL AUTO_INCREMENT,
	TRIP_ID int,
	GUIDE_NUM char( 4 ),
	PRIMARY KEY(ASSOCIATION_ID)
);

ALTER TABLE trip_guides AUTO_INCREMENT=1;

insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 1,	'GZ01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 1,	'RH01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 2,	'AM01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 2,	'SL01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 3,	'SL01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 4,	'BR01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 4,	'GZ01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 5,	'KS01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 5,	'UG01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 6,	'RH01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 7,	'SL01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 8,	'BR01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 9,	'BR01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 10,	'GZ01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 11,	'DH01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 11,	'KS01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 11,	'UG01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 12,	'BR01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 13,	'RH01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 14,	'KS02' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 15,	'GZ01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 16,	'KS02' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 17,	'RH01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 18,	'KS02' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 19,	'DH01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 20,	'SL01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 21,	'AM01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 22,	'UG01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 23,	'DH01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 23,	'SL01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 24,	'BR01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 25,	'BR01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 26,	'GZ01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 27,	'GZ01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 28,	'BR01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 29,	'DH01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 30,	'AM01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 31,	'SL01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 32,	'KS01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 33,	'UG01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 34,	'KS01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 35,	'GZ01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 36,	'KS02' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 37,	'RH01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 38,	'KS02' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 39,	'BR01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 40,	'DH01' );
insert into trip_guides( TRIP_ID, GUIDE_NUM ) values( 41,	'BR01' );

create table guide
(
	GUIDE_NUM	char( 4 ) primary key,
	LAST_NAME	varchar( 12 ),
	FIRST_NAME	varchar( 12 ),
	ADDRESS		varchar( 30 ),
	CITY		varchar( 30 ),
	STATE		char( 2 ),
	POSTAL_CODE	int,
	PHONE_NUM	char( 12 ),
	HIRE_DATE	date
);

insert into guide values( 'AM01',	'Abrams',	'Miles',	'54 Quest Ave.',	'Williamsburg',	'MA',	1096,	'617-555-6032',	'2012-06-03' );
insert into guide values( 'BR01',	'Boyers',	'Rita',	'140 Oakton Rd.',	'Jaffrey',	'NH',	3452,	'603-555-2134',	'2012-03-04' );
insert into guide values( 'DH01',	'Devon',	'Harley',	'25 Old Ranch Rd.',	'Sunderland',	'MA',	1375,	'781-555-7767',	'2012-01-08' );
insert into guide values( 'GZ01',	'Gregory',	'Zach',	'7 Moose Head Rd.',	'Dummer',	'NH',	3588,	'603-555-8765',	'2012-11-04' );
insert into guide values( 'KS01',	'Kiley',	'Susan',	'943 Oakton Rd.',	'Jaffrey',	'NH',	3452,	'603-555-1230',	'2013-04-08' );
insert into guide values( 'KS02',	'Kelly',	'Sam',	'9 Congaree Ave.',	'Fraconia',	'NH',	3580,	'603-555-0003',	'2013-06-10' );
insert into guide values( 'MR01',	'Marston',	'Ray',	'24 Shenandoah Rd.',	'Springfield',	'MA',	1101,	'781-555-2323',	'2015-09-14' );
insert into guide values( 'RH01',	'Rowan',	'Hal',	'12 Heather Rd.',	'Mount Desert',	'ME',	4660,	'207-555-9009',	'2014-06-02' );
insert into guide values( 'SL01',	'Stevens',	'Lori',	'15 Riverton Rd.',	'Coventry',	'VT',	5825,	'802-555-3339',	'2014-09-05' );
insert into guide values( 'UG01',	'Unser',	'Glory',	'342 Pineview St.',	'Danbury',	'CT',	6810,	'203-555-8534',	'2015-02-02' );

CREATE TABLE CUSTOMER
(
 CUSTOMER_NUM INT PRIMARY KEY,
LAST_NAME VARCHAR( 30 ),
FIRST_NAME VARCHAR( 30 ),
ADDRESS VARCHAR( 40 ),
CITY VARCHAR( 30 ),
STATE CHAR(2),
POSTAL_CODE INT,
PHONE CHAR(12)
);


INSERT INTO CUSTOMER VALUES( 101,	'Northfold', 'Liam', '9 Old Mill Rd.',	'Londonderry',	'NH',	3053,	'603-555-7563' );
INSERT INTO CUSTOMER VALUES( 102,	'Ocean', 'Arnold', '2332 South St. Apt 3',	'Springfield',	'MA',	1101,	'413-555-3212' );
INSERT INTO CUSTOMER VALUES( 103,	'Kasuma', 'Sujata', '132 Main St. 1',	'East Hartford',	'CT',	6108,	'860-555-0703' );
INSERT INTO CUSTOMER VALUES( 104,	'Goff', 'Ryan', '164A South Bend Rd.',	'Lowell',	'MA',	1854,	'781-555-8423' );
INSERT INTO CUSTOMER VALUES( 105,	'McLean', 'Kyle', '345 Lower Ave.',	'Wolcott',	'NY',	14590,	'585-555-5321' );
INSERT INTO CUSTOMER VALUES( 106,	'Morontoia', 'Joseph', '156 Scholar St.',	'Johnston',	'RI',	2919,	'401-555-4848' );
INSERT INTO CUSTOMER VALUES( 107,	'Marchand', 'Quinn', '76 Cross Rd.',	'Bath',	'NH',	3740,	'603-555-0456' );
INSERT INTO CUSTOMER VALUES( 108,	'Rulf', 'Uschi', '32 Sheep Stop St.',	'Edinboro',	'PA',	16412,	'814-555-5521' );
INSERT INTO CUSTOMER VALUES( 109,	'Caron', 'Jean Luc', '10 Greenfield St.',	'Rome',	'ME',	4963,	'207-555-9643' );
INSERT INTO CUSTOMER VALUES( 110,	'Bers', 'Martha', '65 Granite St.',	'York',	'NY',	14592,	'585-555-0111' );
INSERT INTO CUSTOMER VALUES( 112,	'Jones', 'Laura', '373 Highland Ave.',	'Somerville',	'MA',	2143,	'857-555-6258' );
INSERT INTO CUSTOMER VALUES( 115,	'Vaccari',	'Adam', '1282 Ocean Walk',	'Ocean CITY',	'NJ',	8226,	'609-555-5231' );
INSERT INTO CUSTOMER VALUES( 116,	'Murakami', 'Iris', '7 Cherry Blossom St.',	'Weymouth',	'MA',	2188,	'617-555-6665' );
INSERT INTO CUSTOMER VALUES( 119,	'Chau', 'Clement', '18 Ark Ledge Ln.',	'Londonderry',	'VT',	5148,	'802-555-3096' );
INSERT INTO CUSTOMER VALUES( 120,	'Gernowski', 'Sadie', '24 Stump Rd.',	'Athens',	'ME',	4912,	'207-555-4507' );
INSERT INTO CUSTOMER VALUES( 121,	'Bretton-Borak', 'Siam', '10 Old Main St.',	'Cambridge',	'VT',	5444,	'802-555-3443' );
INSERT INTO CUSTOMER VALUES( 122,	'Hefferson', 'Orlagh', '132 South St. Apt 27',	'Manchester',	'NH',	3101,	'603-555-3476' );
INSERT INTO CUSTOMER VALUES( 123,	'Barnett', 'Larry', '25 Stag Rd.',	'Fairfield',	'CT',	6824,	'860-555-9876' );
INSERT INTO CUSTOMER VALUES( 124,	'Busa', 'Karen', '12 Foster St.',	'South Windsor',	'CT',	6074,	'857-555-5532' );
INSERT INTO CUSTOMER VALUES( 125,	'Peterson', 'Becca', '51 Fredrick St.',	'Albion',	'NY',	14411,	'585-555-0900' );
INSERT INTO CUSTOMER VALUES( 126,	'Brown', 'Brianne', '154 Central St.',	'Vernon',	'CT',	6066,	'860-555-3234' );
