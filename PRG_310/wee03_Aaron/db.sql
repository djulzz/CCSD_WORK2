

CREATE DATABASE CUSTOMERS;
use CUSTOMERS;
CREATE TABLE ENTRIES
(
	ID int primary key AUTO_INCREMENT,
	LOGIN VARCHAR( 50 ) NOT NULL UNIQUE,
	PASSWORD CHAR( 50 ) NOT NULL,
	EMAIL CHAR( 50 ) NOT NULL UNIQUE
);

INSERT INTO ENTRIES( LOGIN, PASSWORD, EMAIL ) VALUES( 'djulzz', 'pwd', 'julien.esposito@cc-sd.edu' );