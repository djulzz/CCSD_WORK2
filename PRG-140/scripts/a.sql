SELECT CONCAT( DIRECTOR.FIRST_NAME, ' ', DIRECTOR.LAST_NAME ) AS DIRECTOR_NAME,
	   CONCAT( STAR.FIRST_NAME, ' ', STAR.LAST_NAME ) AS STAR
	   FROM DIRECTOR, STAR;