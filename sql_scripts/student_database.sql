# create a database
create database OurBoard;

# select the database
use OurBoard;

# create a Sql Table
create table Students
(
	student_id int primary key,
	firstName varchar( 50 ),
	lastName varchar( 50 )
);

insert into Students values( 101, 'Julien', 'Esposito');
insert into Students values( 102, 'Mitch', 'Rowley');
insert into Students values( 103, 'John', 'Teefy');
insert into Students values( 104, 'Alandro', 'Williams');

# this is how we inspect the structure of our table
describe Students;

# Check content
select * from Students;