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
