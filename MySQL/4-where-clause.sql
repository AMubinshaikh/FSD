-- WHERE Clase is used to filtering data from table with specific condition

SELECT * 
FROM Customers 
WHERE points > 3000;

 SELECT * 
FROM Customers 
WHERE state = 'VA';

 SELECT * 
FROM Customers 
WHERE state != 'VA';

SELECT * 
FROM Customers 
WHERE state <> 'VA';

SELECT * 
FROM Customers 
WHERE birth_date > '1990-01-01';

