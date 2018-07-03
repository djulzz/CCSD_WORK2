# Q1
#1.	(4 pts) List the guide number, first name, and last name for all guides. The first name should appear in lowercase letters and the last name should appear in uppercase letters.
-- SELECT GUIDE_NUM,
-- LOWER( FIRST_NAME ),
-- LAST_NAME FROM GUIDE;

-- 2.	(4 pts) List the trip ID and trip name for all trips that start in Bar Harbor. Your query should ignore the case of how Bar Harbor is entered in the query. For example, a trip with the start location of Bar Harbor should be included as should trips whose start location is BAR HARBOR, Bar harbor, BaR HarBor, and so on.
-- SELECT TRIP_ID,
--  TRIP_NAME FROM
-- TRIP WHERE ( UPPER( START_LOCATION ) = UPPER('BAR HARBOR'));
-- 3.	(4 pts) Every guide receives their first review 6 months after their hire date. List the guide’s last name, first name, hire date and his/her first review date. Use FIRST_REVIEW_DATE as the column title.
-- SELECT LAST_NAME,
--  FIRST_NAME,
--   HIRE_DATE,
--    ADDDATE( HIRE_DATE, INTERVAL 6 MONTH )
--     FROM GUIDE;

-- 4.	(4 pts) Repeat the previous question but display the guides’ names as first name followed by last name (for example, Rita Boyers). Use NAME as the column title for the guides’ names.
SELECT CONCAT(FIRST_NAME, '<---->', LAST_NAME) AS NAME FROM GUIDE;
