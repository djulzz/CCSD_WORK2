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
