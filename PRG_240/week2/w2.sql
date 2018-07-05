
- create tables
	+ student
	+ class
	+ instructor
	+ enrollment
	+ assigned

create database CANVAS_KNOCKOFF;
USE CANVAS_KNOCKOFF;
create table enrollment
(
	student_id INT,
	class_id CHAR( 7 ),
	primary key (student_id, class_id)
);

create table assigned
(
	instructor_id INT,
	class_id CHAR( 7 ),
	primary key (instructor_id, class )
);

	create table student
		(
			ID INT PRIMARY KEY AUTO_INCREMENT,
			FIRST_NAME VARCHAR( 50 ) NOT NULL,
			LAST_NAME VARCHAR( 50 ) NOT NULL 
			);

	create table instructor
		(
			ID INT PRIMARY KEY AUTO_INCREMENT,
			FIRST_NAME VARCHAR( 50 ) NOT NULL,
			LAST_NAME VARCHAR( 50 ) NOT NULL 
			);

#'YYYY-MM-DD'
	create table class
		(
			CODE CHAR( 7 )  NOT NULL PRIMARY KEY
			TITLE  VARCHAR( 60 ) NOT NULL,
			START DATE NOT NULL,
			CREDITS DECIMAL( 2, 1 ) NOT NULL,
			MOD_NUMBER INT NOT NULL
			);


)

insert into student( FIRST_NAME, LAST_NAME ) values( 'Chris', 'Tocky');
insert into student( FIRST_NAME, LAST_NAME ) values( 'Chris', 'Leidig');
insert into student( FIRST_NAME, LAST_NAME ) values( 'Kaleb', 'Kalinowsky');
insert into student( FIRST_NAME, LAST_NAME ) values( 'Sharif', 'Ali');
insert into student( FIRST_NAME, LAST_NAME ) values( 'Emanuel', 'Gonzalez');

insert into class values( 'PRG_240', 'Database Programming II', '2018-06-26', 3.5);
insert into class values( 'OPS_101', 'Operating System I', '2018-06-26', 3.5);
insert into class values( 'ISS_220', 'Computer Law', '2018-06-26', 3.5);

insert into instructor( FIRST_NAME, LAST_NAME ) values( 'Julien', 'Esposito' );
insert into instructor( FIRST_NAME, LAST_NAME ) values( 'Angelo', 'Martinez' );
insert into instructor( FIRST_NAME, LAST_NAME ) values( 'Michael', 'Harris' );

insert into enrollment values( 1, 'PRG_140');
insert into enrollment values( 2, 'OPS_101');

insert into enrollment select student.id, class.code from student, class where ( student.LAST_NAME == 'Tocki') and (class.code = 'PRG_140');