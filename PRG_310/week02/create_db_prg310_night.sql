CREATE DATABASE PRG_310_NIGHT;
USE PRG_310_NIGHT; # Specify DB to work WITH

CREATE TABLE STUDENTS
(
	ID 				INT PRIMARY KEY,
	FIRST_NAME 		VARCHAR( 50 ), # String in C#
	LAST_NAME 		VARCHAR( 50 )
);

INSERT INTO STUDENTS (ID, FIRST_NAME, LAST_NAME) VALUES( 1, 'Julien', 'Esposito');