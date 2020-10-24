--NESTED QUERIES. WHEN A QUERY INSIDE ANOTHER QUERY IS KNOWN AS NESTED QUERY

SELECT first_name, last_name, email
FROM person
WHERE gender ='Male' 
IN (SELECT make, model 
	FROM car
    WHERE ownerCountry = 'India');