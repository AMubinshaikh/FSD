-- ORDER BY is used to SORT data in ASC or DESC order
-- ascending order
SELECT *
FROM Customers
ORDER BY first_name ASC;

-- descending order
SELECT *
FROM Customers
ORDER BY first_name DESC;

SELECT first_name,last_name 
FROM Customers
ORDER BY birth_date;

SELECT first_name,last_name , 10 AS points
FROM Customers
ORDER BY birth_date, points;