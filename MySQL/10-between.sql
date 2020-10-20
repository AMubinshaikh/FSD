-- BETWEEN Statements

SELECT * 
FROM Customers
WHERE points >=1000 AND points <=3000;

-- using between
SELECT * 
FROM Customers
WHERE points BETWEEN 1000 AND 3000;