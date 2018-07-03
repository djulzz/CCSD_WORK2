# Q1
# SELECT GUIDE_NUM, LAST_NAME, FIRST_NAME, HIRE_DATE FROM GUIDE;

# Q2
# SELECT TRIP_NAME, TYPE FROM TRIP WHERE ( TYPE = 'Biking');

# Q3
#SELECT LAST_NAME, STATE FROM GUIDE WHERE ( STATE = 'MA');

# Q4
#SELECT LAST_NAME, STATE FROM GUIDE WHERE( STATE != 'MA');

# Q5
# SELECT TRIP_NAME, DISTANCE FROM TRIP WHERE ( TYPE = 'Hiking') AND ( DISTANCE > 10 );
-- 5.	(4 pts) List the trip name and distance of each trip that has the type Hiking and that has a distance longer than 10 miles.
-- 6.	(4 pts) You are interested in a biking trip in the early fall for more than 10 individuals. List all the columns for those trips that meet your requirements.

# Q7

-- 7.	(4 pts) List the reservation ID and trip price of those reservations that have a trip price that is greater than or equal to $40 but less than or equal to $60.
-- Q8	(4 pts) List the customer number, customer last name, customer first name , city and state of each customer that lives in New Jersey (NJ), New York (NY) or Pennsylvania (PA). Use the IN operator in your command.
-- SELECT CUSTOMER_NUM, LAST_NAME, FIRST_NAME, CITY, STATE WHERE STATE IN( 'NJ', 'NY', 'PA');
SELECT CUSTOMER_NUM, LAST_NAME, FIRST_NAME, CITY, STATE 
FROM CUSTOMER WHERE STATE IN( 'NJ', 'NY', 'PA')
 ORDER BY LAST_NAME DESC, STATE ASC;

# Q10
# select count(*) from trip where ( STATE = 'MA');

# Q11 
-- SELECT COUNT( * ), STATE FROM TRIP GROUP BY STATE;

# Q15
# 15. What is the minimum distance and maximum distance for each type of trip?
# SELECT MIN( DISTANCE ) AS MINIMUM_DISTANCE, MAX( DISTANCE ) AS MAXIMUM_DISTANCE, TYPE FROM TRIP;


# Display the different seasons in which trips are offered. List each season only once.

#SELECT DISTINCT SEASON FROM TRIP;

# Q13.	(4 pts) Colonial Adventure Tours calculates the
# total price of a trip by adding the trip price plus
# other fees and multiplying the result by the number
# of persons included in the reservation. List the
# reservation ID, trip ID, customer number, number of
# persons and total price for all reservations where
# the number of persons is greater than four. Use the
# column name TOTAL_PRICE for the calculated field.
-- SELECT RESERVATION_ID, TRIP_ID, CUSTOMER_NUM,
--  NUM_PERSONS,
--   (NUM_PERSONS*(OTHER_FEES+TRIP_PRICE)) AS TOTAL_PRICE
--    FROM RESERVATION WHERE (NUM_PERSONS > 4);

#Q14
# 14.List the guide’s last name, first name and hire date for all guides that were hired before June 10, 2013. Order your results by the hire date.
-- SELECT LAST_NAME, FIRST_NAME, HIRE_DATE FROM GUIDE WHERE ( HIRE_DATE < '2013-06-10');

#Q18
# 18.	(4 pts) List the reservation IDs for reservations that
# are for a paddling trip. You must use a subquery.
-- ;

-- SELECT RESERVATION_ID FROM RESERVATION WHERE TRIP_ID IN ( SELECT TRIP_ID FROM TRIP WHERE ( TYPE = 'Paddling') )


-- SELECT R.RESERVATION_ID, R.TRIP_ID, C.CUSTOMER_NUM, C.LAST_NAME
-- FROM
-- 	RESERVATION R,
-- 	CUSTOMER C
-- WHERE ( R.CUSTOMER_NUM = C.CUSTOMER_NUM) ORDER BY C.LAST_NAME ASC;

-- 2.	(4 pts) For each reservation for customer Ryan Goff,
--  list the reservation ID, trip ID, and number of persons.
-- SELECT RESERVATION_ID, TRIP_ID, NUM_PERSONS FROM RESERVATION R, CUSTOMER C
-- WHERE ( R.CUSTOMER_NUM = C.CUSTOMER_NUM ) AND ( C.FIRST_NAME = 'Ryan')
-- AND ( C.LAST_NAME = 'Goff');

-- 3
-- SELECT R.RESERVATION_ID, R.TRIP_ID, C.CUSTOMER_NUM, C.LAST_NAME
-- FROM
-- 	RESERVATION R,
-- 	CUSTOMER C
-- WHERE ( R.CUSTOMER_NUM = C.CUSTOMER_NUM) ORDER BY C.LAST_NAME ASC;