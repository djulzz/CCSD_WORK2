
create database flights;

use flights;

DROP TABLE IF EXISTS 'details';
DROP TABLE IF EXISTS 'survey';

create table details
(
		flight_number int primary key,
		airline_code char( 2 ) not null,
		departure_time datetime not null,
		arrival_time datetime not null,
		departure varchar( 50 ),
		arrival varchar( 50 )
		);

create table survey
(
	review_number int primary key auto_increment,
	flight_number int not null,
	airline_code char( 2 ) not null,
	friendliness int not null,
	space int not null,
	confort int not null,
	cleanliness int not null,
	noise int not null,
	review_optional text
);

insert into details values( 1628, 'AA', '2018-08-01 16:00:00', '2018-08-01 20:20:00', 'Cincinnati', 'San Diego' );
insert into details values( 2000, 'LF', '2018-08-01 17:00:00', '2018-08-01 20:40:00', 'Stutgart', 'San Diego' );
insert into details values( 3000, 'BA', '2018-08-01 18:00:00', '2018-08-01 21:00:00', 'London', 'San Diego' );
